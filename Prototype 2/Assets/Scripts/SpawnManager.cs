using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xRange = 25f;
    private float zRange = 20f;
    private float yRange = 15f;
    private float zVerticalRange = 15f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        bool canRandomVertical = Random.Range(0, 2) == 0;
        int animalSpawnIndex = Random.Range(0, animalPrefabs.Length);
        GameObject animal = animalPrefabs[animalSpawnIndex];

        if (canRandomVertical)
        {
            float zRand = Random.Range(4, zVerticalRange);

            bool isGeneratedLeft = Random.Range(-xRange, xRange) < 0;
            float xRand = isGeneratedLeft ? -xRange : xRange;

            Vector3 spawnPos = new Vector3(xRand, 0, zRand);
            Instantiate(animal, spawnPos, isGeneratedLeft ? Quaternion.Euler(0, 90, 0) : Quaternion.Euler(0, -90, 0));
        }
        else
        {
            Vector3 spawnPos = new Vector3(Random.Range(-yRange, yRange), 0, zRange);
            Instantiate(animal, spawnPos, animal.transform.rotation);
        }
    }
}
