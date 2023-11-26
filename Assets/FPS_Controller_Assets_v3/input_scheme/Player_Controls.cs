// GENERATED AUTOMATICALLY FROM 'Assets/FPS_Controller_Assets_v3/input_scheme/Player_Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player_Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player_Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""d720915e-3dde-4be3-8351-0b2d624445c2"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b8b76292-ccbf-4b94-9b97-86ebbc76f995"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c9c95d74-3c82-4a16-be07-fc07470d6ab7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""07391133-1167-40c5-bfed-84fba8f0a5eb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6e30c565-82c0-4115-9e88-3494091c4162"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7e433b31-c954-46aa-ad7e-067d97283676"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ce4d1e6a-87ef-44fb-9780-220745fd2ab3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a9df6349-b199-4d6c-8b1f-2d66c44681b6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4210f56d-36ba-4f24-a086-01187f59df98"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""66201cb2-6780-4b82-ad42-3e382dfbdfea"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fee95c95-4e63-4df1-a7a6-8df4786b12fc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f460c093-45ce-4c05-8289-0f9e19bf1e98"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17ccf9f7-3899-43e7-953b-b251dd5ebeeb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeae9d2d-b30a-4573-b25b-d828d42c5d08"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""0ab9d61b-61af-4051-8b4e-0c43629459cf"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""63a290a0-d0ed-4ff8-85c3-e50756f508df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b9145518-f8ba-4a81-a057-6eb7014f4df7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""0cb79af3-1d6b-48b0-a1b3-1044bc573ec0"",
            ""actions"": [
                {
                    ""name"": ""itm_1"",
                    ""type"": ""Button"",
                    ""id"": ""a3b79005-2fc6-4ad4-8a7e-84223e3f63df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_2"",
                    ""type"": ""Button"",
                    ""id"": ""e8e65b60-0782-4d32-845d-572419504360"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_3"",
                    ""type"": ""Button"",
                    ""id"": ""2a3a6719-d6b3-4006-aae1-b91f0088762d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_4"",
                    ""type"": ""Button"",
                    ""id"": ""e4fe8c11-42a9-4139-b3bd-3aa4860ff625"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_5"",
                    ""type"": ""Button"",
                    ""id"": ""24539677-8d84-45d2-b3f0-cfb68d7861bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_6"",
                    ""type"": ""Button"",
                    ""id"": ""d4a751ac-195e-47bb-9b86-ea99d71c35d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_7"",
                    ""type"": ""Button"",
                    ""id"": ""33e988b5-d77c-49b6-bc4f-ce4534b18d78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_8"",
                    ""type"": ""Button"",
                    ""id"": ""3da059fe-9ecd-4f7d-b3ed-e3a6a3c9bb2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_9"",
                    ""type"": ""Button"",
                    ""id"": ""69cc1c91-3ae2-406b-811b-2810f45c085f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""itm_10"",
                    ""type"": ""Button"",
                    ""id"": ""6fe90c6a-41f0-4d23-bbc6-4acf369b2f6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""scroll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""171d30d0-6b61-49c2-ba5e-9bdf6b1f8638"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1709882b-e9ee-4dd1-8aed-e2c7aef0c6f9"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa4dd5e9-a97c-4adb-ab8c-ef9048267521"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ca75754-1e55-482a-94c6-87ca7e096473"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f2f8946-b33a-43ff-8b4e-9b939fdc00a5"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8deb4745-b1e0-474c-8c1d-fd01599762a8"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b37f478-12a3-41fc-a9b1-4b11b45b337d"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c3422b7-06aa-41d9-9795-a65513aa9f30"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1969ac95-256b-422d-8be6-4e28d827ba34"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8737813f-f2b4-447d-87dd-303d113b1e7d"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74489fba-0581-4aa0-b9fb-8fb98193727a"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""keyboard"",
                    ""action"": ""itm_10"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af00d80e-cc67-4047-a806-1496fbadc4aa"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""keyboard"",
            ""bindingGroup"": ""keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""gamepad"",
            ""bindingGroup"": ""gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Interact = m_Actions.FindAction("Interact", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_itm_1 = m_Inventory.FindAction("itm_1", throwIfNotFound: true);
        m_Inventory_itm_2 = m_Inventory.FindAction("itm_2", throwIfNotFound: true);
        m_Inventory_itm_3 = m_Inventory.FindAction("itm_3", throwIfNotFound: true);
        m_Inventory_itm_4 = m_Inventory.FindAction("itm_4", throwIfNotFound: true);
        m_Inventory_itm_5 = m_Inventory.FindAction("itm_5", throwIfNotFound: true);
        m_Inventory_itm_6 = m_Inventory.FindAction("itm_6", throwIfNotFound: true);
        m_Inventory_itm_7 = m_Inventory.FindAction("itm_7", throwIfNotFound: true);
        m_Inventory_itm_8 = m_Inventory.FindAction("itm_8", throwIfNotFound: true);
        m_Inventory_itm_9 = m_Inventory.FindAction("itm_9", throwIfNotFound: true);
        m_Inventory_itm_10 = m_Inventory.FindAction("itm_10", throwIfNotFound: true);
        m_Inventory_scroll = m_Inventory.FindAction("scroll", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Look;
    public struct PlayerActions
    {
        private @Player_Controls m_Wrapper;
        public PlayerActions(@Player_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_Interact;
    public struct ActionsActions
    {
        private @Player_Controls m_Wrapper;
        public ActionsActions(@Player_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Actions_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @Interact.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_itm_1;
    private readonly InputAction m_Inventory_itm_2;
    private readonly InputAction m_Inventory_itm_3;
    private readonly InputAction m_Inventory_itm_4;
    private readonly InputAction m_Inventory_itm_5;
    private readonly InputAction m_Inventory_itm_6;
    private readonly InputAction m_Inventory_itm_7;
    private readonly InputAction m_Inventory_itm_8;
    private readonly InputAction m_Inventory_itm_9;
    private readonly InputAction m_Inventory_itm_10;
    private readonly InputAction m_Inventory_scroll;
    public struct InventoryActions
    {
        private @Player_Controls m_Wrapper;
        public InventoryActions(@Player_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @itm_1 => m_Wrapper.m_Inventory_itm_1;
        public InputAction @itm_2 => m_Wrapper.m_Inventory_itm_2;
        public InputAction @itm_3 => m_Wrapper.m_Inventory_itm_3;
        public InputAction @itm_4 => m_Wrapper.m_Inventory_itm_4;
        public InputAction @itm_5 => m_Wrapper.m_Inventory_itm_5;
        public InputAction @itm_6 => m_Wrapper.m_Inventory_itm_6;
        public InputAction @itm_7 => m_Wrapper.m_Inventory_itm_7;
        public InputAction @itm_8 => m_Wrapper.m_Inventory_itm_8;
        public InputAction @itm_9 => m_Wrapper.m_Inventory_itm_9;
        public InputAction @itm_10 => m_Wrapper.m_Inventory_itm_10;
        public InputAction @scroll => m_Wrapper.m_Inventory_scroll;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                @itm_1.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_1;
                @itm_1.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_1;
                @itm_1.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_1;
                @itm_2.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_2;
                @itm_2.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_2;
                @itm_2.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_2;
                @itm_3.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_3;
                @itm_3.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_3;
                @itm_3.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_3;
                @itm_4.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_4;
                @itm_4.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_4;
                @itm_4.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_4;
                @itm_5.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_5;
                @itm_5.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_5;
                @itm_5.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_5;
                @itm_6.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_6;
                @itm_6.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_6;
                @itm_6.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_6;
                @itm_7.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_7;
                @itm_7.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_7;
                @itm_7.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_7;
                @itm_8.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_8;
                @itm_8.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_8;
                @itm_8.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_8;
                @itm_9.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_9;
                @itm_9.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_9;
                @itm_9.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_9;
                @itm_10.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_10;
                @itm_10.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_10;
                @itm_10.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnItm_10;
                @scroll.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnScroll;
                @scroll.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnScroll;
                @scroll.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @itm_1.started += instance.OnItm_1;
                @itm_1.performed += instance.OnItm_1;
                @itm_1.canceled += instance.OnItm_1;
                @itm_2.started += instance.OnItm_2;
                @itm_2.performed += instance.OnItm_2;
                @itm_2.canceled += instance.OnItm_2;
                @itm_3.started += instance.OnItm_3;
                @itm_3.performed += instance.OnItm_3;
                @itm_3.canceled += instance.OnItm_3;
                @itm_4.started += instance.OnItm_4;
                @itm_4.performed += instance.OnItm_4;
                @itm_4.canceled += instance.OnItm_4;
                @itm_5.started += instance.OnItm_5;
                @itm_5.performed += instance.OnItm_5;
                @itm_5.canceled += instance.OnItm_5;
                @itm_6.started += instance.OnItm_6;
                @itm_6.performed += instance.OnItm_6;
                @itm_6.canceled += instance.OnItm_6;
                @itm_7.started += instance.OnItm_7;
                @itm_7.performed += instance.OnItm_7;
                @itm_7.canceled += instance.OnItm_7;
                @itm_8.started += instance.OnItm_8;
                @itm_8.performed += instance.OnItm_8;
                @itm_8.canceled += instance.OnItm_8;
                @itm_9.started += instance.OnItm_9;
                @itm_9.performed += instance.OnItm_9;
                @itm_9.canceled += instance.OnItm_9;
                @itm_10.started += instance.OnItm_10;
                @itm_10.performed += instance.OnItm_10;
                @itm_10.canceled += instance.OnItm_10;
                @scroll.started += instance.OnScroll;
                @scroll.performed += instance.OnScroll;
                @scroll.canceled += instance.OnScroll;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);
    private int m_keyboardSchemeIndex = -1;
    public InputControlScheme keyboardScheme
    {
        get
        {
            if (m_keyboardSchemeIndex == -1) m_keyboardSchemeIndex = asset.FindControlSchemeIndex("keyboard");
            return asset.controlSchemes[m_keyboardSchemeIndex];
        }
    }
    private int m_gamepadSchemeIndex = -1;
    public InputControlScheme gamepadScheme
    {
        get
        {
            if (m_gamepadSchemeIndex == -1) m_gamepadSchemeIndex = asset.FindControlSchemeIndex("gamepad");
            return asset.controlSchemes[m_gamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnItm_1(InputAction.CallbackContext context);
        void OnItm_2(InputAction.CallbackContext context);
        void OnItm_3(InputAction.CallbackContext context);
        void OnItm_4(InputAction.CallbackContext context);
        void OnItm_5(InputAction.CallbackContext context);
        void OnItm_6(InputAction.CallbackContext context);
        void OnItm_7(InputAction.CallbackContext context);
        void OnItm_8(InputAction.CallbackContext context);
        void OnItm_9(InputAction.CallbackContext context);
        void OnItm_10(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
    }
}
