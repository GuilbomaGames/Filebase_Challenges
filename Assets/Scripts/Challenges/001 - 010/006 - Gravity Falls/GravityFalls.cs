using System;
using System.Linq;
using UnityEngine;

public class GravityFalls : MonoBehaviour
{
    // handle to the rigidbody
    // handle to the floor meshRenderer
    // if I hit the space key, activate the rigidbody gravity and turn the floor meshRenderer red
    // if the sphere hits the floor, turn the floor meshRenderer blue and destroy me

    private Rigidbody _rigidbody;
    private MeshRenderer _floorMesh;
        
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _floorMesh = GameObject.Find("Floor").GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.useGravity = true;
            _floorMesh.material.color = Color.red;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
            _floorMesh.material.color = Color.blue;
            Destroy(this.gameObject);
        }
    }
}