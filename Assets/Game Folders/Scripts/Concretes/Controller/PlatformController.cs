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

        [SerializeField] private float JumpForce = 10f;

        private void Awake()
        {
            _score =GameObject.Find("Canvas").GetComponentInChildren<Score>();
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




            
            gameObject.AddComponent<Rigidbody2D>();
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(DestroyCounter());
            
            
        }

        IEnumerator DestroyCounter()
        {
            yield return new WaitForSeconds(5f);
            Destroy(gameObject);
        }

    }

}

