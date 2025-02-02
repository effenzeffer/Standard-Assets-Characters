// GENERATED AUTOMATICALLY FROM 'Assets/_Standard Assets/Characters/Scriptable Objects/Control Map/StandardControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class StandardControls : IInputActionCollection
{
    private InputActionAsset asset;
    public StandardControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""StandardControls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""401f0562-653c-45d7-b6af-d43a16e5e984"",
            ""actions"": [
                {
                    ""name"": ""mouseLook"",
                    ""type"": ""Value"",
                    ""id"": ""94fe90c2-2b91-475e-9d50-bb9f6e833c98"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""gamepadLook"",
                    ""type"": ""Value"",
                    ""id"": ""18ffe753-4cc1-45fc-8377-f9b5292b1a4b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""21a14e86-4fb7-49f9-af14-ddbfc9451078"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""crouch"",
                    ""type"": ""Value"",
                    ""id"": ""5800e495-214e-474b-b3e0-57242409f8c1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""recentre"",
                    ""type"": ""Value"",
                    ""id"": ""f8e6d38a-3004-4632-bb57-209532eda966"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""sprint"",
                    ""type"": ""Value"",
                    ""id"": ""cba1b438-67f2-4fc1-b3d0-9129c5ba7640"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""strafe"",
                    ""type"": ""Value"",
                    ""id"": ""fb80f938-13a8-4a49-aacb-b1323e025a3d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Value"",
                    ""id"": ""e0e21268-ad74-44f1-bd3d-e2909ad65769"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b5e4169a-ddc2-444e-8947-5c50310ce7ce"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7171b02-bd2f-4eaa-90a5-3de8ca9d7c4b"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5823f7a4-35f6-4490-8075-00e60e53960a"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""recentre"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a3fdf70-fad4-4d19-bcf7-434572a3a2ff"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""recentre"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""effb5bdc-89f2-4815-931b-381c603a16ed"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6916ba45-ea9d-43b1-909c-427e71ef7072"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""480c3b85-5bd5-47bd-a6d1-a4fa3d4698d0"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afaf61b1-2cc6-4419-87cc-1658b7d3796f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d71f3c76-ea57-455a-817f-7a2a9708f387"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc020caf-f33b-4678-a947-14711e61e59a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6350393e-2ea8-4399-88ad-38aa713e5cc5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.2,y=0.2)"",
                    ""groups"": """",
                    ""action"": ""gamepadLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08a6f928-9ff7-4bfd-94a8-42d5c1e5965c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""b0b67dc2-e40e-400e-b741-0ac7a433e00a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""940c555b-5bf3-4002-a31e-37d5c07b02f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6e468804-50f7-4d55-934f-b3a48b83bfed"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9511bfd7-bfde-4706-9974-7e8e7322c223"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1c9ac3f5-20aa-4d8d-8b0b-e5f0276aa445"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d0ea204a-b4ba-4d75-b646-ab2c4ed37ece"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.01,y=0.01)"",
                    ""groups"": """",
                    ""action"": ""mouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.GetActionMap("Movement");
        m_Movement_mouseLook = m_Movement.GetAction("mouseLook");
        m_Movement_gamepadLook = m_Movement.GetAction("gamepadLook");
        m_Movement_move = m_Movement.GetAction("move");
        m_Movement_crouch = m_Movement.GetAction("crouch");
        m_Movement_recentre = m_Movement.GetAction("recentre");
        m_Movement_sprint = m_Movement.GetAction("sprint");
        m_Movement_strafe = m_Movement.GetAction("strafe");
        m_Movement_jump = m_Movement.GetAction("jump");
    }

    ~StandardControls()
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_mouseLook;
    private readonly InputAction m_Movement_gamepadLook;
    private readonly InputAction m_Movement_move;
    private readonly InputAction m_Movement_crouch;
    private readonly InputAction m_Movement_recentre;
    private readonly InputAction m_Movement_sprint;
    private readonly InputAction m_Movement_strafe;
    private readonly InputAction m_Movement_jump;
    public struct MovementActions
    {
        private StandardControls m_Wrapper;
        public MovementActions(StandardControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @mouseLook => m_Wrapper.m_Movement_mouseLook;
        public InputAction @gamepadLook => m_Wrapper.m_Movement_gamepadLook;
        public InputAction @move => m_Wrapper.m_Movement_move;
        public InputAction @crouch => m_Wrapper.m_Movement_crouch;
        public InputAction @recentre => m_Wrapper.m_Movement_recentre;
        public InputAction @sprint => m_Wrapper.m_Movement_sprint;
        public InputAction @strafe => m_Wrapper.m_Movement_strafe;
        public InputAction @jump => m_Wrapper.m_Movement_jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                mouseLook.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseLook;
                mouseLook.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseLook;
                mouseLook.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseLook;
                gamepadLook.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnGamepadLook;
                gamepadLook.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnGamepadLook;
                gamepadLook.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnGamepadLook;
                move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                crouch.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                crouch.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                crouch.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                recentre.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRecentre;
                recentre.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRecentre;
                recentre.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRecentre;
                sprint.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                sprint.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                sprint.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnSprint;
                strafe.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnStrafe;
                strafe.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnStrafe;
                strafe.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnStrafe;
                jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                mouseLook.started += instance.OnMouseLook;
                mouseLook.performed += instance.OnMouseLook;
                mouseLook.canceled += instance.OnMouseLook;
                gamepadLook.started += instance.OnGamepadLook;
                gamepadLook.performed += instance.OnGamepadLook;
                gamepadLook.canceled += instance.OnGamepadLook;
                move.started += instance.OnMove;
                move.performed += instance.OnMove;
                move.canceled += instance.OnMove;
                crouch.started += instance.OnCrouch;
                crouch.performed += instance.OnCrouch;
                crouch.canceled += instance.OnCrouch;
                recentre.started += instance.OnRecentre;
                recentre.performed += instance.OnRecentre;
                recentre.canceled += instance.OnRecentre;
                sprint.started += instance.OnSprint;
                sprint.performed += instance.OnSprint;
                sprint.canceled += instance.OnSprint;
                strafe.started += instance.OnStrafe;
                strafe.performed += instance.OnStrafe;
                strafe.canceled += instance.OnStrafe;
                jump.started += instance.OnJump;
                jump.performed += instance.OnJump;
                jump.canceled += instance.OnJump;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnMouseLook(InputAction.CallbackContext context);
        void OnGamepadLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnRecentre(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
