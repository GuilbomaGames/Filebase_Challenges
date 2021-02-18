using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameDevHQ.Challenge.Challenge_Easy_Master_Spawner.Scripts
{
    public class SpawnManager : MonoBehaviour
    {
        public GameObject[] objectsToSpawn;
        private int _objectsSpawned;
        
        //every two seconds, spawn 4 random game objects from the array

        private void Start()
        {
            StartCoroutine(SpawnRoutine());
        }

        private IEnumerator SpawnRoutine()
        {
            while (true)
            {
                int spawnIndex = Random.Range(0, objectsToSpawn.Length);
                Instantiate(objectsToSpawn[spawnIndex]);
                _objectsSpawned++;

                if (_objectsSpawned == 4)
                {
                    yield return new WaitForSeconds(2.0f);
                    _objectsSpawned = 0;
                }
            }
        }
    }
}
