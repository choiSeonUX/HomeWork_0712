using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        // Å°ÀÔ·Â 
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.velocity = newVelocity;

    }

    public void Die()
    {
        gameObject.SetActive(false);
        
    }


}
