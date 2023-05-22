using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    private float moveSpeed = 4;

    private float maxPosScene = 4;
    void Start()
    {
        
    }

    
    void Update()
    {
        Movement();
        DecreaseLives();
    }
    private void Movement()
    {
        

        transform.Translate(Vector3.forward  * moveSpeed * Time.deltaTime);

        
    }

    private void DecreaseLives()
    {
        if (transform.position.z < -maxPosScene)
        {
            GameManager.currentLives--;
            Destroy(gameObject);
            Debug.Log("Game Over !!");
        }
        
        
    }
}
