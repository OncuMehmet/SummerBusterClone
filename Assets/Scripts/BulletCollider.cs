using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    public float radius = 15f;
    public float power = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Man")//tagi man olan objelere explosion yap�cak
        {
            this.GetComponent<CapsuleCollider>().enabled = false;
            this.GetComponent<MeshRenderer>().enabled = false;
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);//kendimiz bir collider olu�turduk

           // Debug.Log("explode");
            foreach(Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(power, explosionPos, radius, 1.0f);
                }
            }

        }
    }

}
