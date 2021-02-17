using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionPrefab : MonoBehaviour
{
    
    // handle to the destroy position
    // the player should automatically walk to the right and gets destroyed at the destroy position
    
    private Transform _destroyPosition;
    
    private void Start()
    {
        _destroyPosition = GameObject.Find("DestroyPosition").transform;
    }
    
    private void Update()
    {
        transform.Translate(Vector3.right * (3 * Time.deltaTime));
        
        if (transform.position.x > _destroyPosition.position.x)
        {
            Destroy(this.gameObject);
        }
    }
}
