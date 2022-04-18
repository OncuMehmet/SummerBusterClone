using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; //Yeni input system i kullanmak i�in ekledik

public class MachineMovement : MonoBehaviour
{
    MachineInput machineInput;
    [SerializeField] float machineRotateValue=5f;
    CharacterController charecterController;
    [SerializeField] Vector3 machineMovementValue;
    float machineMovementSpeed = 6f;
    float gravity = -9.8f;
    


    private void Awake()
    {
        machineInput = new MachineInput();
        machineMovementValue = new Vector3(0f,0f,0f); //ba�larken sorun ya�amas�n diye 0 a e�itledik en ba�ta
    }

    // Start is called before the first frame update
    void Start()
    {
        charecterController = GetComponent<CharacterController>();
        machineInput.Machine.Rotate.started += machineRotateStart;
        
        
        machineInput.Machine.Move.performed += machineMovePerformed;
        machineInput.Machine.Move.canceled += machineMovePerformed; //�uan bunu ayn� fonksiyonda  yapt�k ��nk� ektra bir animasyon vs kullanmad���m�zdan sadece veri �ekmek i�in kullan�yoruz sorunsuz suan.

        
    }

    // Update is called once per frame
    void Update()
    {
        charecterController.Move(machineMovementValue);
    }
    public void machineRotateStart(InputAction.CallbackContext context)
    {
       // Debug.Log(context.ReadValue<Vector2>());
        transform.Rotate(new Vector3(0f, context.ReadValue<Vector2>().x * Time.deltaTime * machineRotateValue, 0f));
    }
    public void machineMovePerformed(InputAction.CallbackContext context)
    { //i�eriye bir de�er �a�r�l�rsa Move de�erlerini g�ncelliycez
        machineMovementValue = new Vector3(0f, gravity, context.ReadValue<Vector2>().x * Time.deltaTime*machineMovementSpeed);
    }



    private void OnEnable()//yeni input systemi aktive etmek i�in kullan�yoruz
    {
        machineInput.Enable();
    }
    private void OnDisable()
    {
        machineInput.Disable();
    }
}
