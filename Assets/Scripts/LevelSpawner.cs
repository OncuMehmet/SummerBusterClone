using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public GameObject[] levelPrefabs;
   
    
    public GameObject CreateLevel()
    {
        GameObject obj = Instantiate(levelPrefabs[LevelController.Instance.level]);//levelPrefabs oluþturma yönemini yazdýk
        return obj; //objemiz elimizde olsun diye return ediyoruz 
    }

}
