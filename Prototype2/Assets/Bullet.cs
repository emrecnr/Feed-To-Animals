using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 10f;
    private int scoreAmount = 10;

    private void Update()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Animal")
)       {
            Destroy(other.gameObject);
            FindObjectOfType<Score>().AddScore(scoreAmount);
            FindObjectOfType<Score>().GameSpeedControl(scoreAmount);

        }
        Destroy(gameObject);

    }
}
