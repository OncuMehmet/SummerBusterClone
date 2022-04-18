using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //navMesh kullanabilek için ekledik

public class PlayerControllerNavMesh : MonoBehaviour
{
    NavMeshAgent nav;
    [SerializeField] GameObject followdObject;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
       
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = followdObject.transform.position; //NavMesin bu noktaya gitmesini saðlar
    }

}
