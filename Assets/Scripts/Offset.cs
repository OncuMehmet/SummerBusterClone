using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    MeshRenderer mesh;
    float scroolSpeed = 0.15f;


    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>(); 
       // Invoke(nameof(offsetStop), 48.5f);
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Time.time * scroolSpeed; //x yönünende 
        mesh.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));//prototype metaryel ismi offset de ilk deðer x deðeri x de hareket edecek
        
    }
    
}
