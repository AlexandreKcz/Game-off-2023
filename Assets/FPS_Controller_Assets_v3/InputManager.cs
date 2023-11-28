using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    private static InputManager _instance;

    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    Player_Controls playerControls;

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;
        playerControls = new Player_Controls();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return playerControls.Player.Movement.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta()
    {
        return playerControls.Player.Look.ReadValue<Vector2>();
    }

    public bool PlayerJumpedThisFrame()
    {
        return playerControls.Player.Jump.triggered;
    }

    public bool PlayerInteractThisFrame()
    {
        return playerControls.Actions.Interact.triggered;
    }

    public int selectedItem()
    {
        if (playerControls.Inventory.itm_1.triggered) return 0;
        if (playerControls.Inventory.itm_2.triggered) return 1;
        if (playerControls.Inventory.itm_3.triggered) return 2;
        if (playerControls.Inventory.itm_4.triggered) return 3;
        if (playerControls.Inventory.itm_5.triggered) return 4;
        if (playerControls.Inventory.itm_6.triggered) return 5;
        if (playerControls.Inventory.itm_7.triggered) return 6;
        if (playerControls.Inventory.itm_8.triggered) return 7;
        if (playerControls.Inventory.itm_9.triggered) return 8;
        if (playerControls.Inventory.itm_10.triggered) return 9;

        return -1;
    }

    public float getScrollValue()
    {
        return playerControls.Inventory.scroll.ReadValue<float>();
    }
}
