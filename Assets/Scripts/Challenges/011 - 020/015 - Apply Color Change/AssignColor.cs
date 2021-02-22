using UnityEngine;

namespace Challenges
{
    public class AssignColor : MonoBehaviour
    {
        // Assign a random color to me
        // If the player hits the space key
        // color the other cube to the same color I have

        private Color _randomColor;
        private MeshRenderer _cubeMesh;
        private GameObject _cubeToColor;
        
        void Start()
        {
            _randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f),
                Random.Range(0f, 1f));

            _cubeMesh = GetComponent<MeshRenderer>();
            _cubeMesh.material.color = _randomColor;
            
            _cubeToColor = GameObject.Find("Change_Me");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                _cubeToColor.GetComponent<MeshRenderer>().material.color = _randomColor;
            }
        }
    }
}
