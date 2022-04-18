using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forCanvas : MonoBehaviour
{
    public Text SkorText;
   
    private void Start()
    {
        
    }
    private void Update()
    {
        SkorText.text = "Skor: " + Skor.skorToplam.ToString();
    }
    
}
