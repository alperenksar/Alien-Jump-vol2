using AlienJump.Manager;
using AlienJump.Managers;
using AlienJump.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlienJump.Controller
{
    public class PlatformController : MonoBehaviour
    {
        Score _score;

        LevelManager _levelManager;


        private Camera MainCam;
        [SerializeField] private float JumpForce = 10f;

        private void Awake()
        {
            MainCam = Camera.main;
            _levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
            _score =GameObject.Find("Canvas").GetComponentInChildren<Score>();
        }

        private void LateUpdate()
        {
            if (MainCam.transform.position.y - 10 > transform.position.y)
            {
                Destroy(gameObject);
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {

            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

            if (rb == null) return;

            if (rb.velocity.y > 0f) return;

            if (gameObject.CompareTag("Type2"))
            {
                GameManager.Instance.StopGame();
            }

            else if (gameObject.CompareTag("Type1"))
            {
                _score._Score += 1;
                Vector2 velocity = rb.velocity;
                velocity.y = JumpForce;
                rb.velocity = velocity;
            }

            else if (gameObject.CompareTag("Type3"))
            {
                _score._Score += 10;
                Vector2 velocity = rb.velocity;
                velocity.y = JumpForce * 2;
                rb.velocity = velocity;
            }

            _levelManager._counterOfCycle -= 1;

            gameObject.AddComponent<Rigidbody2D>();
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
                       
        }
     

    }

}

