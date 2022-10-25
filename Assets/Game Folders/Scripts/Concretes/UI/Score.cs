using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AlienJump.UI
{
    public class Score : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _scoreText;
        [SerializeField] public int _Score;

        private void Update()
        {
            _scoreText.text = _Score.ToString();
        }

    }

}
