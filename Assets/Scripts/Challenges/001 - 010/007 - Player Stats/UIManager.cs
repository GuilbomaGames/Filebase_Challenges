// using UnityEngine;
// using UnityEngine.UI;
//
// public class UIManager : MonoBehaviour
// {
//     // handle to the Player script
//     // handle to the PlayerName
//     // handle to the AttackLevel
//     // handle to the MagicLevel
//     // handle to the SmitingLevel
//     // handle to the MiningLevel
//     // show the values at runtime
//
//     private Player _player;
//     [SerializeField] private Text playerName;
//     [SerializeField] private Text attackLevel;
//     [SerializeField] private Text magicLevel;
//     [SerializeField] private Text smitingLevel;
//     [SerializeField] private Text miningLevel;
//         
//     private void Start()
//     {
//         _player = GameObject.Find("Player").GetComponent<Player>();
//
//         if (_player != null)
//         {
//             playerName.text = "Player Name: " + _player.playerName;
//             attackLevel.text = "Attack lvl: " + _player.attackLevel;
//             magicLevel.text = "Magic lvl:" + _player.magicLevel;
//             smitingLevel.text = "Smiting lvl: " + _player.smithingLevel;
//             miningLevel.text = "Mining lvl:" + _player.miningLevel;
//         }
//     }
// }