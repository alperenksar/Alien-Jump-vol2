using AlienJump.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienJump.UI
{
    public class ExitButton : MonoBehaviour
    {
       public void ExitGame()
        {
            GameManager.Instance.ExitGame();
        }
    }

}
