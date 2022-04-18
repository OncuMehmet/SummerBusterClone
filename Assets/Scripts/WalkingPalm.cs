using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingPalm : MonoBehaviour
{

    [SerializeField] GameObject palm1, palm2; //2 aðaç arasýnda volta atýcak onlarý secmek için yaptýk
    NavMeshAgent nav;
    int index = 1;
    bool isBoatSeen = false;
   // bool isFinishLine = false;
    GameObject boat;
    //GameObject finishLine;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.destination = palm1.transform.position; //ilk doðduðunda 1.palmý takip et
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBoatSeen)
        {
            if (nav.remainingDistance < 1f) //varmak istediði noktaya ne kadar uzakda kaldýðýný gösteren bir fonksiyon remaininDistance
            {
                index = (index + 1) % 2; //0 ile 1 arasýnda gidip gelsin diye yaptýk bunu
                if (index == 0)
                {
                    nav.destination = palm1.transform.position;
                }
                else
                {
                    nav.destination = palm2.transform.position;
                }
            }
    
        }
        else if(isBoatSeen) //bot görünüyorsa
        {
            nav.destination = boat.transform.position;
        }
        //else if (finishLine)
        //{
        //    nav.destination = finishLine.transform.position;
        //}

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boat") //botu gördüm artýk onu takip etmeliyim
        {
            isBoatSeen = true;
            //nav.destination = other.transform.position; //bot objesini takip et
            boat = other.gameObject;

        }
        else if (other.tag == "FinishLine") //kaptaný görünce
        {
            // isFinishLine= true;
            //nav.destination = other.transform.position;
            //finishLine = other.gameObject;
            Debug.Log("Finish Çalýþtý");
            LevelController.Instance.LevelSuccess();
        }
    }
}
