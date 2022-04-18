using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BoatControler : MonoBehaviour
{
  
    MachineInput boatInput;
    Vector3 movementValue;
    [SerializeField] float movementSpeed = 400f;
    [SerializeField] float directionSpeed = 100f;

    private void Awake()
    {
        boatInput = new MachineInput(); //OBJE HALÝNDE OLUSTURDUK
        movementValue = Vector3.zero; //Avake esnasýnda boþ gelmesin diye tanýmaladýk
    }

    // Start is called before the first frame update
    void Start()
    {
        boatInput.Machine.BoatMove.started += SetMovementValue;
        boatInput.Machine.BoatMove.performed += SetMovementValue;
        boatInput.Machine.BoatMove.canceled += SetMovementValueCanceled;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementSpeed * movementValue * Time.deltaTime*5);//hareket
    }
    
    public void SetMovementValue(InputAction.CallbackContext context)
    {
       movementValue = new Vector3(-context.ReadValue<Vector2>().x*directionSpeed, context.ReadValue<Vector2>().y*directionSpeed, 0f);
        

        
    }
    
    public void SetMovementValueCanceled(InputAction.CallbackContext context)
    {
        movementValue = Vector3.zero; //0 0 0 yaptýk
       
    }


    private void OnEnable()
    {
        boatInput.Enable();
    }
    private void OnDisable()
    {
        boatInput.Disable();
    }

}
