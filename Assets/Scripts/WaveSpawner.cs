using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab; // Prefab to spawn
    [SerializeField] private float startTime; // Time to start the wave spawning
    [SerializeField] private float endTime; // Time to end the wave spawning
    [SerializeField] private float spawnRate; // Time between each spawn

    // Start is called before the first frame update
    void Start()
    {
        WaveManager.instance.AddWave(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    void EndSpawner()
    {
        WaveManager.instance.RemoveWave(this);
        CancelInvoke();
    }
}
