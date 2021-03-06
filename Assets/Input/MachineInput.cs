// GENERATED AUTOMATICALLY FROM 'Assets/Input/MachineInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MachineInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MachineInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MachineInput"",
    ""maps"": [
        {
            ""name"": ""Machine"",
            ""id"": ""daa1ec8e-e1e3-4dbe-83fc-c145152d3947"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""590d06a6-c7af-48f9-8b7a-cf201c017f6f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d2500f76-3897-43df-9560-d55e0a055036"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BoatMove"",
                    ""type"": ""Value"",
                    ""id"": ""fc8e084f-f9f0-4e17-8483-3a76be216fad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2bbb9be6-d7ce-4a7b-ae0a-1a93d67c8811"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bc846a0-b741-41e6-958d-baa02ce6c45c"",
                    ""path"": ""<Touchscreen>/touch0/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a5e7fc8d-61f9-4459-a0ce-b1daf530b823"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d157d09b-7f67-4601-83ad-00ec54270bcf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5a8d07dc-bdb9-4cce-abb5-b5246dba7e99"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""709fff0b-035e-4e1f-9669-8827ad3ada91"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d8dca66c-fd97-4c14-8f38-14049d947ba7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9c3ce9a0-bebe-49b0-a712-b52974fafba5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""705998d9-8db3-4314-bb17-47dffb39b77a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""86f08e94-d131-4c33-b104-bb4c8f97ba70"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1eaadb15-a848-4ffd-9537-417985f95651"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4d9d6fc1-6c62-4fe0-b7ba-de2b39e02005"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""97d99ec4-e161-4f5e-92a0-a1a7054b6a49"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3a08880a-4a29-4eab-a285-b8282e8959b6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5392a3d0-ede2-4aa6-9393-cc3161864c35"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0169d21c-5115-45a6-9137-f6d2005711e3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""214342e0-1efa-4697-8427-3af805a96df4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""701abd9d-a274-4290-9e0b-f3b674b819bb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2375dfa2-c7d9-4cfd-85e2-b5456b4f541f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""654b4446-8f79-4883-8c14-cf1e5389cd86"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e0efaa90-e7a7-425f-a1c1-7ecdacf28e00"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""077a0352-1c9a-47e4-87f7-63b581fb07f6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoatMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Machine
        m_Machine = asset.FindActionMap("Machine", throwIfNotFound: true);
        m_Machine_Rotate = m_Machine.FindAction("Rotate", throwIfNotFound: true);
        m_Machine_Move = m_Machine.FindAction("Move", throwIfNotFound: true);
        m_Machine_BoatMove = m_Machine.FindAction("BoatMove", throwIfNotFound: true);
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

    // Machine
    private readonly InputActionMap m_Machine;
    private IMachineActions m_MachineActionsCallbackInterface;
    private readonly InputAction m_Machine_Rotate;
    private readonly InputAction m_Machine_Move;
    private readonly InputAction m_Machine_BoatMove;
    public struct MachineActions
    {
        private @MachineInput m_Wrapper;
        public MachineActions(@MachineInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Machine_Rotate;
        public InputAction @Move => m_Wrapper.m_Machine_Move;
        public InputAction @BoatMove => m_Wrapper.m_Machine_BoatMove;
        public InputActionMap Get() { return m_Wrapper.m_Machine; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MachineActions set) { return set.Get(); }
        public void SetCallbacks(IMachineActions instance)
        {
            if (m_Wrapper.m_MachineActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_MachineActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_MachineActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_MachineActionsCallbackInterface.OnRotate;
                @Move.started -= m_Wrapper.m_MachineActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MachineActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MachineActionsCallbackInterface.OnMove;
                @BoatMove.started -= m_Wrapper.m_MachineActionsCallbackInterface.OnBoatMove;
                @BoatMove.performed -= m_Wrapper.m_MachineActionsCallbackInterface.OnBoatMove;
                @BoatMove.canceled -= m_Wrapper.m_MachineActionsCallbackInterface.OnBoatMove;
            }
            m_Wrapper.m_MachineActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @BoatMove.started += instance.OnBoatMove;
                @BoatMove.performed += instance.OnBoatMove;
                @BoatMove.canceled += instance.OnBoatMove;
            }
        }
    }
    public MachineActions @Machine => new MachineActions(this);
    public interface IMachineActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnBoatMove(InputAction.CallbackContext context);
    }
}
