using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public GameObject[] levelPrefabs;
   
    
    public GameObject CreateLevel()
    {
        GameObject obj = Instantiate(levelPrefabs[LevelController.Instance.level]);//levelPrefabs olu�turma y�nemini yazd�k
        return obj; //objemiz elimizde olsun diye return ediyoruz 
    }

}
