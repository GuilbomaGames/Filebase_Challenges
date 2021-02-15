using UnityEngine;

namespace Challenges
{
    public class DifficultySelector : MonoBehaviour
    {
        // variable for a difficulty ID
        // when pressing the space key print out the difficulty of the chosen ID

        [SerializeField][Range(0, 2)] private int difficultyID;
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                switch (difficultyID)
                {
                    case 0:
                        Debug.Log("You selected 'Easy'!");
                        break;
                    case 1:
                        Debug.Log("You selected 'Medium'!");
                        break;
                    case 2:
                        Debug.LogWarning("You selected 'Hard'!");
                        break;
                    default:
                        Debug.LogError("Invalid ID! Please choose an ID between 0 and 2!");
                        break;
                }
            }
        }
    }
}
