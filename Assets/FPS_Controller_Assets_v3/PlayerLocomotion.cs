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
    #endregion

    private CharacterController _controller;

    private Transform _cameraTransform;

    private Vector3 _playerVelocity;

    private bool groundedPlayer;

    private bool _lockPlayer = false;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();

        _cameraTransform = _camera.transform;
    }

    public void UpdatePlayerLocomotion(Vector2 movement, bool playerJumpedThisFrame, float delta)
    {
        if (_lockPlayer) return;
        groundedPlayer = _controller.isGrounded;
        if (groundedPlayer && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(movement.x, 0f, movement.y);

        move = _cameraTransform.forward * move.z + _cameraTransform.right * move.x;
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
