using UnityEngine;

public class ASL : MonoBehaviour
{
    // Variable for age
    // Variable for gender
    // Variable for location

    [SerializeField] private int age;
    [SerializeField] private char gender;
    [SerializeField] private string location;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Your age: " + age);
            Debug.Log("Your gender: " + gender);
            Debug.Log("Your location: " + location);
        }
    }
}