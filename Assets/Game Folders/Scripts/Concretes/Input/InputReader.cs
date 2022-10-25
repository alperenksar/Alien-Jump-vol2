using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlienJump.Inputs
{
    public class InputReader : MonoBehaviour
    {
        

        public void FixedTick(Camera _mainCam,GameObject _hero)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                Debug.Log("Position: " + _mainCam.ScreenToWorldPoint(touch.position));
                _hero.transform.position = new Vector3(_mainCam.ScreenToWorldPoint(touch.position).x, _hero.transform.position.y, _hero.transform.position.z);
            }
        }

       








}
    

}
