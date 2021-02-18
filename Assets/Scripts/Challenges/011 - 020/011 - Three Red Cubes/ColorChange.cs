using UnityEngine;

namespace Challenges
{
    public class ColorChange : MonoBehaviour
    {
        //game object array for the cubes
        // if I hit the space key, turn all 3 cube MeshRenderer red

        [SerializeField] private GameObject[] cubes;
        
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var t in cubes)
                {
                    t.GetComponent<MeshRenderer>().material.color = Color.red;
                }
            }
        }
    }
}
