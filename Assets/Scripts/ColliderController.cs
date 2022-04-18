using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Man")
        {
            Destroy(other.gameObject);
           
        }
        else if (other.tag == "FinishLine")
        {
            
            Debug.Log("Finish Çalýþtý");
            LevelController.Instance.LevelSuccess();
        }
    }

}
