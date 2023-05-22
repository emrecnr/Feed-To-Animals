using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float moveSpeed = 15f;
    private float maxPosX=18;
    private float maxPosY;

    [SerializeField] private GameObject bullet;

    private void Update()
    {
        Movement();
        Shoot();
    }
    private void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right*moveX*moveSpeed*Time.deltaTime);

        if (transform.position.x< -maxPosX)
        {
            transform.position = new Vector3(-maxPosX,transform.position.y,transform.position.z);
        }
        if (transform.position.x > maxPosX)
        {
            transform.position = new Vector3(maxPosX, transform.position.y, transform.position.z);
        }
    }
    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position+new Vector3(0,1.5f,0f), Quaternion.identity);
        }
        
    }
}
