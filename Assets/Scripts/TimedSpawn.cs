using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject Spawner;
    public bool _stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    [SerializeField]
    private Transform[] SpawnPos;
    int random;

// Start is called before the first frame update
    void Start() 
    {
        Time.timeScale = 1f;
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        int randPosition = Random.Range(0,SpawnPos.Length);
        Instantiate(Spawner,SpawnPos[randPosition].position,Quaternion.identity);
    }

    public void StopSpawning()
    {
        Debug.Log("IT should stop spawning");
        CancelInvoke("SpawnObject");
    }
}
