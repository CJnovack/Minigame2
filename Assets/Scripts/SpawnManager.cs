using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float spawnRangeX = 20;
    private float spawnRangeY = 15;
    private float spawnPosZ = 0;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomCube()
    {
        int cubeIndex = Random.Range(0, Prefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, spawnRangeY), 0, spawnPosZ);

        Instantiate(Prefabs[cubeIndex], spawnPos, Prefabs[cubeIndex].transform.rotation);
    }
}
