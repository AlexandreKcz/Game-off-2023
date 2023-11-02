using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    #region tweaks
    [Header("Controller Tweaks")]
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    #endregion

    private CharacterController controller;
    private InputManager inputManager;

    private Transform cameraTransform;

    private Vector3 playerVelocity;

    private bool groundedPlayer;

    public bool lockPlayer = false;

    private void Start()
    {
        controller = GetComponent<CharacterController>();

        inputManager = InputManager.Instance;

        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        if (lockPlayer) return;
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movement = inputManager.GetPlayerMovement();
        Vector3 move = new Vector3(movement.x, 0f, movement.y);

        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        move.y = 0;

        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (inputManager.PlayerJumpedThisFrame() && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    public void TeleportPlayer(Vector3 position)
    {
        controller.enabled = false;
        this.transform.position = position;
        controller.enabled = true;
    }
}
