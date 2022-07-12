using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody bulletRigidbody; 
    public float speed = 3f;
    public float degreePerSecond = 50f;
   
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed; // ¼Óµµ 

        Destroy(gameObject, 3f); 
    }

    
      void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                PlayerControl playcontrol = other.GetComponent<PlayerControl>();

                if (playcontrol != null)
                {
                    playcontrol.Die();
             
                }
            }
        }
 
}
