using AlienJump.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlienJump.UI
{
    public class GameOverPanel : MonoBehaviour
    {
      
        public void RestartGame()
        {
            GameManager.Instance.LoadScene(0);
        }

      
    }

}

