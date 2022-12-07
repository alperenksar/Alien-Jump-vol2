using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AlienJump.Inputs;
using AlienJump.Managers;

namespace AlienJump.Controller
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Horizontal Movement")]
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private float _horizontalSpeed;
 
        HorizontalMovement horizontalMovement;

        InputReader _input;

        private void Awake()
        {
            Time.timeScale = 1f;
            _input = new InputReader();
            horizontalMovement = new HorizontalMovement();
        }

        private void Update()
        {
            if (transform.position.y < _mainCamera.transform.position.y - 10)
            {
                Time.timeScale = 0f;
                GameManager.Instance.StopGame();
            }

        }

        private void FixedUpdate()
        {
            horizontalMovement.FixedTick(_mainCamera, this.gameObject,_horizontalSpeed);
        }


    }

}
