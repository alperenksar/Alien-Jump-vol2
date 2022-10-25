using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public void FixedTick(Camera _mainCam, GameObject _hero,float MovementSpeed)
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            _hero.transform.position = (new Vector3(_mainCam.ScreenToWorldPoint(touch.position).x* MovementSpeed, _hero.transform.position.y, _hero.transform.position.z));

            if (_mainCam.ScreenToWorldPoint(touch.position).x < 0)
            {
                _hero.transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else
            {
                _hero.transform.localScale = new Vector3(-1f, 1f, 1f);

            }


            Debug.Log(touch.position.x);

        }
    }
}
