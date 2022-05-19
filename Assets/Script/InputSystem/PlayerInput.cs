// GENERATED AUTOMATICALLY FROM 'Assets/Script/InputSystem/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""CharacterControllers"",
            ""id"": ""86fc0d62-fd43-4f45-a673-538a4137a3a4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b5170610-945a-4165-a135-1dd40a2f2e04"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""7334183a-6e77-4e71-8d63-f9bd58a6be23"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fb4ce3fa-a930-436e-8719-0fa7e917fbbe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""5d3933c6-8778-454f-a368-ba7c13a50017"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""f84298ce-5b3d-40aa-bf24-d9020dde88a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""7aae64c2-c406-45e8-87ad-0bf24f7a7485"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeTarget"",
                    ""type"": ""Button"",
                    ""id"": ""085de85c-6005-451b-8d0c-a8da8d89d289"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard / WSAD"",
                    ""id"": ""98d0b486-3c50-4d83-ae98-6d02842a6531"",
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
                    ""id"": ""330c4db7-587c-48be-941d-52c2bf3314ac"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0c6bc647-d0b8-4b72-960c-0161b8c581ae"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7b9c8f23-8fc5-40c6-a9f2-5d788308d82c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f75fda7a-d9cc-46cd-8f45-92caa5948a81"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard / Arrow"",
                    ""id"": ""ee946f83-be1f-41aa-ac0a-b25b76e33e7b"",
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
                    ""id"": ""2dbd737d-f240-4b36-b4df-6e59df0727b3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""91789105-fee6-4f20-be56-0837b69539ea"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8dfefa94-01ea-4601-83de-f8e076bcac40"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f53e1fdc-d7e7-45a7-be84-21b35f19fe81"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4303700b-5b1e-4fc3-88f8-2a6fc650eec8"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""851c2721-0693-4c74-ae27-e2b7ed9ddce1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""181c0c16-f62b-4f34-8fd1-5c72b29d6372"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6400dbbd-376d-43fe-ae9b-f2ea8b861b02"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69a5d092-3b22-4561-a9df-52f3f4ebe90c"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ad345e1-4f57-4eee-83bb-53cb0cd1365e"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""0be84964-da5a-4f1b-a4f6-2f1398a46e41"",
            ""actions"": [
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""abfed9b6-1a90-45d4-8730-db12e122c90f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8d19aa70-b2a1-4760-ba33-9bfbe5191be5"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterControllers
        m_CharacterControllers = asset.FindActionMap("CharacterControllers", throwIfNotFound: true);
        m_CharacterControllers_Movement = m_CharacterControllers.FindAction("Movement", throwIfNotFound: true);
        m_CharacterControllers_Run = m_CharacterControllers.FindAction("Run", throwIfNotFound: true);
        m_CharacterControllers_Jump = m_CharacterControllers.FindAction("Jump", throwIfNotFound: true);
        m_CharacterControllers_Fire = m_CharacterControllers.FindAction("Fire", throwIfNotFound: true);
        m_CharacterControllers_Use = m_CharacterControllers.FindAction("Use", throwIfNotFound: true);
        m_CharacterControllers_Crouch = m_CharacterControllers.FindAction("Crouch", throwIfNotFound: true);
        m_CharacterControllers_ChangeTarget = m_CharacterControllers.FindAction("ChangeTarget", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
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

    // CharacterControllers
    private readonly InputActionMap m_CharacterControllers;
    private ICharacterControllersActions m_CharacterControllersActionsCallbackInterface;
    private readonly InputAction m_CharacterControllers_Movement;
    private readonly InputAction m_CharacterControllers_Run;
    private readonly InputAction m_CharacterControllers_Jump;
    private readonly InputAction m_CharacterControllers_Fire;
    private readonly InputAction m_CharacterControllers_Use;
    private readonly InputAction m_CharacterControllers_Crouch;
    private readonly InputAction m_CharacterControllers_ChangeTarget;
    public struct CharacterControllersActions
    {
        private @PlayerInput m_Wrapper;
        public CharacterControllersActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CharacterControllers_Movement;
        public InputAction @Run => m_Wrapper.m_CharacterControllers_Run;
        public InputAction @Jump => m_Wrapper.m_CharacterControllers_Jump;
        public InputAction @Fire => m_Wrapper.m_CharacterControllers_Fire;
        public InputAction @Use => m_Wrapper.m_CharacterControllers_Use;
        public InputAction @Crouch => m_Wrapper.m_CharacterControllers_Crouch;
        public InputAction @ChangeTarget => m_Wrapper.m_CharacterControllers_ChangeTarget;
        public InputActionMap Get() { return m_Wrapper.m_CharacterControllers; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterControllersActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterControllersActions instance)
        {
            if (m_Wrapper.m_CharacterControllersActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnJump;
                @Fire.started -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnFire;
                @Use.started -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnUse;
                @Crouch.started -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnCrouch;
                @ChangeTarget.started -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnChangeTarget;
                @ChangeTarget.performed -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnChangeTarget;
                @ChangeTarget.canceled -= m_Wrapper.m_CharacterControllersActionsCallbackInterface.OnChangeTarget;
            }
            m_Wrapper.m_CharacterControllersActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @ChangeTarget.started += instance.OnChangeTarget;
                @ChangeTarget.performed += instance.OnChangeTarget;
                @ChangeTarget.canceled += instance.OnChangeTarget;
            }
        }
    }
    public CharacterControllersActions @CharacterControllers => new CharacterControllersActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Zoom;
    public struct CameraActions
    {
        private @PlayerInput m_Wrapper;
        public CameraActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface ICharacterControllersActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnChangeTarget(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnZoom(InputAction.CallbackContext context);
    }
}
