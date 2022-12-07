using AlienJump.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlienJump.UI
{
    public class PlayButton : MonoBehaviour
    {
       public void StartGame(int level)
        {
            GameManager.Instance.LoadScene(level);
        }
    }

}
