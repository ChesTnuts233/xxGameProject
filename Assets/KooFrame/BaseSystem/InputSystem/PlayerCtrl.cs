//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputSystem/PlayerCtrl.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#if ENABLE_INPUT_SYSTEM


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerCtrl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerCtrl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCtrl"",
    ""maps"": [
        {
            ""name"": ""Player3rdCtrl"",
            ""id"": ""f182a30f-9bfb-400d-b54b-974db6fad406"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""14ab3212-e5af-4f95-9235-c2a1642c645d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""88fd68c5-3b75-48c3-b85e-1be50ecbff42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""2ed7963f-bc49-43ab-97f5-319c4da04080"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""50a5727c-7bb6-4ade-aa67-f64590043897"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ed0e0954-f594-4342-9d86-09988ee2592d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""baa9b8e9-e81e-4f9b-abaf-0573085d4b0a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""87b10291-51d6-47d1-a4c3-868b755aec9c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""36d9800e-e986-48ab-b42e-a7ae1699c746"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1583ab8d-8435-442e-99fd-aedd357658ca"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""268edfbb-c9ce-4ae4-8555-1ad7a9a4022e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player1stCtrl"",
            ""id"": ""3cc1e1e4-c8df-4232-9410-2ada45676c8d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1a4f2277-19d1-4a77-9486-12097dc47682"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3ef73536-f84a-47a7-97fc-9fe9c0a22f8d"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7f3c6b67-585b-4b8d-ad76-a3006c8174c3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""90213c19-02cf-4dfa-b447-af14b9497ddd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""96910a32-dfba-4aaa-a0b3-9811d73d1508"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""50e263ff-4d06-4128-9f1c-abce1745d5e6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
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
        }
    ]
}");
        // Player3rdCtrl
        m_Player3rdCtrl = asset.FindActionMap("Player3rdCtrl", throwIfNotFound: true);
        m_Player3rdCtrl_Move = m_Player3rdCtrl.FindAction("Move", throwIfNotFound: true);
        m_Player3rdCtrl_Sprint = m_Player3rdCtrl.FindAction("Sprint", throwIfNotFound: true);
        m_Player3rdCtrl_Jump = m_Player3rdCtrl.FindAction("Jump", throwIfNotFound: true);
        // Player1stCtrl
        m_Player1stCtrl = asset.FindActionMap("Player1stCtrl", throwIfNotFound: true);
        m_Player1stCtrl_Move = m_Player1stCtrl.FindAction("Move", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player3rdCtrl
    private readonly InputActionMap m_Player3rdCtrl;
    private IPlayer3rdCtrlActions m_Player3rdCtrlActionsCallbackInterface;
    private readonly InputAction m_Player3rdCtrl_Move;
    private readonly InputAction m_Player3rdCtrl_Sprint;
    private readonly InputAction m_Player3rdCtrl_Jump;
    public struct Player3rdCtrlActions
    {
        private @PlayerCtrl m_Wrapper;
        public Player3rdCtrlActions(@PlayerCtrl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player3rdCtrl_Move;
        public InputAction @Sprint => m_Wrapper.m_Player3rdCtrl_Sprint;
        public InputAction @Jump => m_Wrapper.m_Player3rdCtrl_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player3rdCtrl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player3rdCtrlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer3rdCtrlActions instance)
        {
            if (m_Wrapper.m_Player3rdCtrlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnMove;
                @Sprint.started -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnSprint;
                @Jump.started -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Player3rdCtrlActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_Player3rdCtrlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public Player3rdCtrlActions @Player3rdCtrl => new Player3rdCtrlActions(this);

    // Player1stCtrl
    private readonly InputActionMap m_Player1stCtrl;
    private IPlayer1stCtrlActions m_Player1stCtrlActionsCallbackInterface;
    private readonly InputAction m_Player1stCtrl_Move;
    public struct Player1stCtrlActions
    {
        private @PlayerCtrl m_Wrapper;
        public Player1stCtrlActions(@PlayerCtrl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1stCtrl_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player1stCtrl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1stCtrlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1stCtrlActions instance)
        {
            if (m_Wrapper.m_Player1stCtrlActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player1stCtrlActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1stCtrlActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1stCtrlActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player1stCtrlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public Player1stCtrlActions @Player1stCtrl => new Player1stCtrlActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    public interface IPlayer3rdCtrlActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlayer1stCtrlActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
#endif