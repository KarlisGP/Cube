using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnDelay = 3f;
    public float spawnRadius = 20f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnCube();
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    void SpawnCube()
    {
        Vector3 randomOffset = Random.insideUnitSphere * spawnRadius;
        Vector3 spawnPosition = transform.position + randomOffset;

        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}