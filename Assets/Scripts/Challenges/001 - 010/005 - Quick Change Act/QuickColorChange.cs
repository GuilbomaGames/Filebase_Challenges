using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Challenges
{
    public class QuickColorChange : MonoBehaviour
    {
        // variable for horizontal movement
        // variable for vertical movement
        // if the player triggers the Wall tag,
        // assign the Player a new random color
        
        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            float horizontalMovement = Input.GetAxis("Horizontal");

            const float speed = 4;
            transform.Translate(new Vector3(horizontalMovement, 0, 0) * (speed * Time.deltaTime));
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Wall"))
            {
                var meshRenderer = this.GetComponent<MeshRenderer>();
                meshRenderer.material.color = new Color(Random.Range(0f, 1f),Random.Range(0f, 1f),Random.Range(0f, 1f), 1);
            }
        }
    }
}
