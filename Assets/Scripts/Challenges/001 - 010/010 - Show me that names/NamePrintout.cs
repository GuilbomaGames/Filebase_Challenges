using UnityEngine;

namespace Challenges
{
    public class NamePrintout : MonoBehaviour
    {
        // name storage array
        
        // if I hit the space key, print out every name in the array

        [SerializeField] private string[] names;
        

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                foreach (var t in names)
                {
                    Debug.Log(t);
                }
            }
        }
    }
}
