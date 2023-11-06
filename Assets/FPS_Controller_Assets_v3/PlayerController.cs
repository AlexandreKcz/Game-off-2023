using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField][Tooltip("main Camera for interaction & locomotion")] private Camera playerCamera;

    private InputManager _inputManager;
    private PlayerLocomotion _locomotion;
    private InteractionManager _interaction;

    private void Awake()
    {
        _inputManager = InputManager.Instance;

        if(_inputManager == null)
        {
            _inputManager = FindObjectOfType<InputManager>();
            Debug.LogWarning("InputManager.Instance is null when calling instance from PlayerController, setting from FindObjectOfType");

        }

        _locomotion = GetComponent<PlayerLocomotion>();
        _interaction = GetComponent<InteractionManager>();

        _locomotion.Camera = playerCamera;
        _interaction.Camera = playerCamera;
    }

    private void Update()
    {
        float delta = Time.deltaTime; //utilisation d'un delta universel obligatoire

        Vector2 movement = _inputManager.GetPlayerMovement();
        bool playerJumped = _inputManager.PlayerJumpedThisFrame();
        bool playerInteracted = _inputManager.PlayerInteractThisFrame();

        _locomotion.UpdatePlayerLocomotion(movement, playerJumped, delta);
        if (playerInteracted) _interaction.checkForInteraction();
    }
}
