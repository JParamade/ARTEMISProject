using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Prefab")]
    public GameObject character;

    [Header("Spawner Settings")]
    [SerializeField] private float spawnTime;
    private float spawnTimer;

    private void Start()
    {
        spawnTimer = spawnTime;
    }

    private void Update()
    {
        if (GameManager.Instance.gameStarted)
        {
            spawnTime -= Time.deltaTime;
            if (spawnTime <= 0)
            {
                Spawn();
                spawnTime = spawnTimer;
            }
        }
    }

    private void Spawn()
    {
        Instantiate(character, gameObject.transform.position, Quaternion.identity);
    }
}
