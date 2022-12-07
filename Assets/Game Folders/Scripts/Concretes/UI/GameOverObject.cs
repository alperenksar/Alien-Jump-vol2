using AlienJump.Managers;
using AlienJump.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlienJump.UI
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameOverPanel _gameOverPanel;

        private void Awake()
        {
            _gameOverPanel.gameObject.SetActive(false);
        }
    

        private void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameStop;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;

        }
         
        void HandleOnGameStop()
        {
            Time.timeScale = 0;
            _gameOverPanel.gameObject.SetActive(true);
        }
    }

}
