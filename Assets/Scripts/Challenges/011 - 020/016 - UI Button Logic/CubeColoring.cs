using UnityEngine;

namespace Challenges
{
    public class CubeColoring : MonoBehaviour
    {
        // Spawn a cube if "Spawn a cube" button is pressed
        // handle to that cube
        // "Turn that cube red!" should turn the cube red
        // Nothing should break when you hit "Turn that cube red" before you spawned the cube

        private GameObject _cube;
        private MeshRenderer _cubeMesh;

        public void SpawnCube()
        {
            _cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            _cubeMesh = _cube.GetComponent<MeshRenderer>();
        }

        public void ColorCube()
        {
            if (_cube != null)
                _cubeMesh.material.color = Color.red;

            else
                Debug.LogError("Please spawn the cube first!");
        }
    }
}
