using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float makeBulletMin = 0.5f;
    public float makeBulletMax = 3f;
    public float degreePerSecond = 100f;
    public float speed = 5f; 

    private Transform target;
    private float makeBullet;
    private float elaspedtime;

    private void Start()
    {
        elaspedtime = 0f;
        makeBullet = Random.Range(makeBulletMin, makeBulletMax);
        target = FindObjectOfType<PlayerControl>().transform;   
                  
    }

    void Update()
    {
        elaspedtime += Time.deltaTime;

        //BulletSpawner bulletSpawner = GetComponent<BulletSpawner>();
       // bulletSpawner.transform.Rotate(Vector3.right * speed * degreePerSecond);

        transform.Rotate(Vector3.up * speed * degreePerSecond);

        if (elaspedtime >= makeBullet)
        {
            elaspedtime = 0;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);          
            makeBullet = Random.Range(makeBulletMin, makeBulletMax);
        }   

    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        PlayerControl playcontrol = other.GetComponent<PlayerControl>();

    //        if (playcontrol != null)
    //        {
    //            BulletSpawner bulletSpawner = other.GetComponent<BulletSpawner>();
    //            bulletSpawner.transform.Rotate(Vector3.right * speed * degreePerSecond);
    //        }
    //    }
    //}
}
