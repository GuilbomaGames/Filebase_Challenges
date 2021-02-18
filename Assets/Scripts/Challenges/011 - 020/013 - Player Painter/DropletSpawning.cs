using UnityEngine;

namespace Challenges
{
    public class DropletSpawning : MonoBehaviour
    {
        // Move the player around with WASD
        // while walking around, drop Droplets at the player position
        // if I'm not walking don't spawn droplets

        private bool _isMoving;
        [SerializeField]  private GameObject dropletPrefab;

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            var horizontalMovement = Input.GetAxis("Horizontal");
            var verticalMovement = Input.GetAxis("Vertical");
            
            transform.Translate(new Vector3(horizontalMovement, verticalMovement, 0) * Time.deltaTime);
            
            if (horizontalMovement != 0.0f || verticalMovement != 0.0f)
            {
                _isMoving = true;
            }

            else
            {
                _isMoving = false;
            }

            if (_isMoving)
            {
                Instantiate(dropletPrefab, transform.position, Quaternion.identity);
            }

        }
    }
}
