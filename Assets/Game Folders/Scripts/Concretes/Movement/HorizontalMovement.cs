using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    private Vector3 _touchFirst;
    private Vector3 _touchSecond;

    private bool _IsDragStarted;


    public void FixedTick(Camera _mainCam, GameObject _hero, float MovementSpeed)
    {
        if (Input.touchCount <= 0) return;

        Touch touch = Input.GetTouch(0);

        if (_mainCam.ScreenToWorldPoint(touch.position).x - _hero.transform.position.x > 2) return;

            
        if (touch.phase == TouchPhase.Moved)
        {
            _hero.transform.position = (new Vector3(_mainCam.ScreenToWorldPoint(touch.position).x * MovementSpeed, _hero.transform.position.y, _hero.transform.position.z));

        }

      
        if (_mainCam.ScreenToWorldPoint(touch.position).x < 0)
        {
            _hero.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            _hero.transform.localScale = new Vector3(-1f, 1f, 1f);

        }
    }







}


    //if (Input.touchCount > 0)
    //{
    //    Touch touch = Input.GetTouch(0);

    //    _hero.transform.position = (new Vector3(_mainCam.ScreenToWorldPoint(touch.position).x* MovementSpeed, _hero.transform.position.y, _hero.transform.position.z));

    //    if (_mainCam.ScreenToWorldPoint(touch.position).x < 0)
    //    {
    //        _hero.transform.localScale = new Vector3(1f, 1f, 1f);
    //    }
    //    else
    //    {
    //        _hero.transform.localScale = new Vector3(-1f, 1f, 1f);

    //    }

    //}

