using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMinion : MonoBehaviour
{
    
    // handle to the spawn position
    // handle to the Player prefab
    // when I hit the space key, spawn the player prefab

    
    private Transform _spawnPosition;
    [SerializeField] private GameObject minionPrefab;
    
    void Start()
    {
        _spawnPosition = GameObject.Find("Spawn_Position").transform;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(minionPrefab, _spawnPosition.position, Quaternion.identity);
        }
    }
}
