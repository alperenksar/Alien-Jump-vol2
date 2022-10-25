using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using AlienJump.Abstracts.Utilities;

namespace AlienJump.Managers
{
    public class GameManager : SingletonBehaviour<GameManager>
    {
        public event System.Action OnGameStop;

        private void Awake()
        {
            SingletonThisObject(this);
        }

        public void StopGame()
        {
            Time.timeScale = 0f;


            OnGameStop?.Invoke();
        }

        public void LoadScene(int sceneNumber)
        {
            StartCoroutine(LoadSceneAsync(sceneNumber));
        }

        IEnumerator LoadSceneAsync(int sceneNumber)
        {
            Time.timeScale = 1f;
            yield return SceneManager.LoadSceneAsync(sceneNumber);
        }

        public void TurnMenu()
        {
            SceneManager.LoadScene(0);
        }

        public void ExitGame()
        {
            Debug.Log("Exit process is running");
            Application.Quit();
        }

    }

}