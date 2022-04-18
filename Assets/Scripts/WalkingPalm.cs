using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingPalm : MonoBehaviour
{

    [SerializeField] GameObject palm1, palm2; //2 a�a� aras�nda volta at�cak onlar� secmek i�in yapt�k
    NavMeshAgent nav;
    int index = 1;
    bool isBoatSeen = false;
   // bool isFinishLine = false;
    GameObject boat;
    //GameObject finishLine;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        nav.destination = palm1.transform.position; //ilk do�du�unda 1.palm� takip et
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBoatSeen)
        {
            if (nav.remainingDistance < 1f) //varmak istedi�i noktaya ne kadar uzakda kald���n� g�steren bir fonksiyon remaininDistance
            {
                index = (index + 1) % 2; //0 ile 1 aras�nda gidip gelsin diye yapt�k bunu
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
        else if(isBoatSeen) //bot g�r�n�yorsa
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
        if (other.tag == "Boat") //botu g�rd�m art�k onu takip etmeliyim
        {
            isBoatSeen = true;
            //nav.destination = other.transform.position; //bot objesini takip et
            boat = other.gameObject;

        }
        else if (other.tag == "FinishLine") //kaptan� g�r�nce
        {
            // isFinishLine= true;
            //nav.destination = other.transform.position;
            //finishLine = other.gameObject;
            Debug.Log("Finish �al��t�");
            LevelController.Instance.LevelSuccess();
        }
    }
}
