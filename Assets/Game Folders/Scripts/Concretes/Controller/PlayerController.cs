using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AlienJump.Inputs;

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
            _input = new InputReader();
            horizontalMovement = new HorizontalMovement();
        }

        private void Update()
        {
          

        }

        private void FixedUpdate()
        {
            horizontalMovement.FixedTick(_mainCamera, this.gameObject,_horizontalSpeed);
        }


    }

}
