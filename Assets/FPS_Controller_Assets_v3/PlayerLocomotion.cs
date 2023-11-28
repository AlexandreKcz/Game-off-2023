using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    private Camera _camera;
    public Camera Camera
    {
        get { return _camera; }
        set { _camera = value; }
    }

    public bool LockPlayer
    {
        get { return _lockPlayer; }
        set { _lockPlayer = value; }
    }

    #region tweaks
    [Header("Controller Tweaks")]
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    [Range(0f, 20f)] [SerializeField]
    private float climbSpeed = 2.0f;
    [Range(0f, 20f)] [SerializeField]
    private float climbAngleOffset = 2.0f;
    #endregion

    private CharacterController _controller;
    private AudioManager _audioManager;

    private Transform _cameraTransform;

    private Vector3 _playerVelocity;

    private bool groundedPlayer;

    private bool _lockPlayer = false;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();

        _audioManager = AudioManager.instance;

        _cameraTransform = _camera.transform;
    }

    public void UpdatePlayerLocomotion(Vector2 movement, bool playerJumpedThisFrame, float delta)
    {
        if (_lockPlayer) return;

        // Check if the player is climbing a ladder
        RaycastHit climbPoint;
        bool isClimbingLadder = Physics.Raycast(gameObject.transform.position, new Vector3(_cameraTransform.forward.x, 0, _cameraTransform.forward.z), out climbPoint, 0.75f, LayerMask.GetMask("Ladder"));
        Vector3 normalLadderReflect = Vector3.Reflect(climbPoint.normal, climbPoint.normal);

        /*-----Sounds-----*/
        string currentFootstepSound = "footsteps_wood";
        string currentLadderClimbSound = "ladder_climb_wood";

        if (((movement.x == 0 && movement.y == 0) || !groundedPlayer || isClimbingLadder) && _audioManager.IsPlaying(currentFootstepSound))
        {
            _audioManager.Stop(currentFootstepSound);
        }
        if (movement.y == 0 && _audioManager.IsPlaying(currentLadderClimbSound))
        {
            _audioManager.Stop(currentLadderClimbSound);
        }

        if (isClimbingLadder && (Mathf.Abs(gameObject.transform.forward.x - normalLadderReflect.x) < climbAngleOffset && Mathf.Abs(gameObject.transform.forward.z - normalLadderReflect.z) < climbAngleOffset))
		{
            // Ladder Climb Sound
            if (movement.y != 0 && !_audioManager.IsPlaying(currentLadderClimbSound))
            {
                _audioManager.Play(currentLadderClimbSound);
            }

            Vector3 moveClimb = new Vector3(0f, movement.y*climbSpeed, 0f);
            _controller.Move(moveClimb * delta);
            return;
        }

        if (_audioManager.IsPlaying(currentLadderClimbSound))
        {
            _audioManager.Stop(currentLadderClimbSound);
        }

        groundedPlayer = _controller.isGrounded;
        if (groundedPlayer && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(movement.x, 0f, movement.y);

        Vector3 _normalizedCamVectorForward = _cameraTransform.forward;
        _normalizedCamVectorForward.y = 0;
        _normalizedCamVectorForward.Normalize();
        Vector3 _normalizedCamVectorRight = _cameraTransform.right;
        _normalizedCamVectorRight.y = 0;
        _normalizedCamVectorRight.Normalize();

        move = _normalizedCamVectorForward * move.z + _normalizedCamVectorRight * move.x;
        move.y = 0;

        _controller.Move(move * delta * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (playerJumpedThisFrame && groundedPlayer)
        {
            _playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        
        // Footstep Sound
        if((movement.x != 0 || movement.y != 0) && groundedPlayer && !_audioManager.IsPlaying(currentFootstepSound))
		{
            _audioManager.Play(currentFootstepSound);
		}

        _playerVelocity.y += gravityValue * delta;
        _controller.Move(_playerVelocity * delta);
    }

    public void TeleportPlayer(Vector3 position)
    {
        _controller.enabled = false;
        this.transform.position = position;
        _controller.enabled = true;
    }
}
