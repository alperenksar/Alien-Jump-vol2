using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


namespace AlienJump.Controller
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform PlayerTransform;

        private Vector3 newPos;

        private void LateUpdate()
        {
            if (PlayerTransform.position.y > transform.position.y)
            {

                newPos = new Vector3(transform.position.x, PlayerTransform.position.y, transform.position.z);
                transform.position = newPos;

            }
        }
    }

}

