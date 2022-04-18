using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    float bulletValue=15f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBullet();
        }
    }
    public void CreateBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = new Vector3(this.transform.position.x, this.transform.position.y+5, this.transform.position.z);
        bullet.GetComponent<Rigidbody>().AddForce(new Vector3(-500f*bulletValue, 0f, 0f), ForceMode.Force);
    }
}
