using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skor : MonoBehaviour
{
    public static int skorToplam;
   
    

    // Start is called before the first frame update
    void Start()
    {
        if (skorToplam >= 400)
        {
            LevelController.Instance.LevelSuccess();
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Man") && gameObject.tag == "Skor10")
        {
            
            skorToplam += 10;
        }
        if (other.gameObject.CompareTag("Man") && gameObject.tag == "Skor20")
        {
          
            skorToplam += 20;

        }
        if (other.gameObject.CompareTag("Man") && gameObject.tag == "Skor30")
        {

            
            skorToplam += 30;

        }
        if (other.gameObject.CompareTag("Man") && gameObject.tag == "Skor40")
        {

            
            skorToplam += 40;
        }

    }
    
}
