using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class SphereControl : MonoBehaviour
{
    // When I hit the space key, sphere 1 falls down.
    // If Sphere 1 hits the ground, Sphere 1 turns red and Sphere 2 falls.
    // If Sphere 2 hits the ground, Sphere 2 turns red and Sphere 3 falls.
    // If Sphere 3 hits the ground, all spheres turn green
    // handle to all 3 MeshRenderers 
    // handle to all 3 Rigidbodies

    private GameObject sphere1;
    private GameObject sphere2;
    private GameObject sphere3;
    private void Start()
    {
        sphere1 = GameObject.Find("Sphere_01");
        sphere2 = GameObject.Find("Sphere_02");
        sphere3 = GameObject.Find("Sphere_03");
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sphere1.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere_01")
        {
            Destroy(sphere1.GetComponent<Rigidbody>());
            sphere1.GetComponent<MeshRenderer>().material.color = Color.red;
            sphere2.GetComponent<Rigidbody>().useGravity = true;
        }
        
        if (other.name == "Sphere_02")
        {
            Destroy(sphere2.GetComponent<Rigidbody>());
            sphere2.GetComponent<MeshRenderer>().material.color = Color.red;
            sphere3.GetComponent<Rigidbody>().useGravity = true;
        }

        
        if (other.name == "Sphere_03")
        {
            Destroy(sphere3.GetComponent<Rigidbody>());
            sphere1.GetComponent<MeshRenderer>().material.color = Color.green;
            sphere2.GetComponent<MeshRenderer>().material.color = Color.green;
            sphere3.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
