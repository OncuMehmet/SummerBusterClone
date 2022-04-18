using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int level;
    public static LevelController Instance;
    LevelSpawner levelSpawner;
    GameObject levelObject;  //levelprefabıni tutmamız lazımki sonradan Destroy edebilelim

    private void Awake()
    {
       PlayerPrefs.SetInt("Level", 0); //daha sonradan level 0a eşitlekmek istersek bunu yap
        Instance = this; //erişilebilir bir konumda şuan
        level = PlayerPrefs.GetInt("Level",0); //ilk leveli sorguluyoruz kullanıcı daha önce içeri girmediyse null döner dönmesin diye default değer veriyoruz.Daa yoksa 0 levelden başla demek

    }
    // Start is called before the first frame update
    void Start()
    {
        //şuanki leveli bana ver 
        levelSpawner = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<LevelSpawner>();//levelSpawner için sahneden gamemasterı istedik game objesi olduğu için GetComponentle belirttik
        levelObject= levelSpawner.CreateLevel(); //levelobject olarak kayıt etmiş olduk level spawnerdean gelen levelprafabi
        Invoke(nameof(LevelSuccess), 20);
        Invoke(nameof(CancelInvoke), 21);//21 saniye bekle kapat 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LevelSuccess()
    {
        level++;
        PlayerPrefs.SetInt("Level", level); //kullanıcı telefonuna data kaydediyoruz
        Destroy(levelObject); //elimizdeki leveli destroy ediyoruz ///
        levelObject = levelSpawner.CreateLevel(); //ardından yeni level yaratılacak ///
    }
    public void LevelFail()
    {

    }
    public void CancelInvokeLog()
    {
        CancelInvoke(nameof(LevelSuccess));
       // Destroy(levelObject); //elimizdeki leveli destroy ediyoruz
       // levelObject = levelSpawner.CreateLevel(); //ardından yeni level yaratılacak
       
    }
    public void level2()
    {

    }
}
