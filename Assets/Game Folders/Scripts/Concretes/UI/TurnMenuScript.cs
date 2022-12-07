using AlienJump.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlienJump.UI
{
    public class TurnMenuScript : MonoBehaviour
    {
        public void TurnMenu()
        {
            GameManager.Instance.TurnMenu();
        }
    }

}
