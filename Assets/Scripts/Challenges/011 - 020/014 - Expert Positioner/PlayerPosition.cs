using UnityEngine;

namespace Challenges
{
    public class PlayerPosition : MonoBehaviour
    {
        // If I hit 1, spawn me at position 1
        // If I hit 2, spawn me at position 2
        // If I hit 3, spawn me at position 3
        

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                transform.position = GameObject.Find("Position_1").transform.position;
            }
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                transform.position = GameObject.Find("Position_2").transform.position;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                transform.position = GameObject.Find("Position_3").transform.position;
            }
            
        }
    }
}
