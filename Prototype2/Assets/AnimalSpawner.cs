using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;

    private float spawnPosX = 17;
    private float spawnPosZ = 20;

    private float timer;
    public static float spawnInterval = 3f;
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        Spawner();
    }
    void Spawner()
    {
        timer += Time.deltaTime;

        if (timer>spawnInterval)
        {
            //rastgele spawn noktasý 
            Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);

            //rastgele spawn olacak hayvan
            int animalIndex = Random.Range(0, animals.Length);

            //Spawn
            Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);

            timer = 0;
            
        }
        
    }
}
