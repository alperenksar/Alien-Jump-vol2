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

        private void Update()
        {
            if (Time.timeScale == 0f)
            {
                _gameOverPanel.gameObject.SetActive(true);
            }
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameStop += HandleOnGameStop;
        }

       

        void HandleOnGameStop()
        {
            _gameOverPanel.gameObject.SetActive(true);
        }

        private void OnDisable()
        {
            GameManager.Instance.OnGameStop -= HandleOnGameStop;

        }
    }

}
