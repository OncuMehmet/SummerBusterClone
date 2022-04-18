using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second : MonoBehaviour
{
    LevelController levelController;

    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(nameof(FinishSecond));
      //  Invoke(nameof(FinishLevel),20); 
       // Invoke(nameof(CancelInvoke),21);//11 saniye bekle kapat 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FinishLevel()
    {
         Debug.Log("20 saniye geçti sonraki levele geç");
       // LevelController.Instance.LevelSuccess(); çalýþmýyor düzgün
        
    }
    public void CancelInvokeLog()
    {
        CancelInvoke(nameof(FinishLevel));
    }

   
    


}
