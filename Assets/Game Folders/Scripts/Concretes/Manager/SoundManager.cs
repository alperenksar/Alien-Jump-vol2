using AlienJump.Abstracts.Utilities;
using AlienJump.Managers;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace AlienJump.Manager
{
    public class SoundManager : SingletonBehaviour<SoundManager>
    {
        [SerializeField] AudioSource[] audioSources;
        [SerializeField] AudioClip audioClip;

        private void Awake()
        {
            SingletonThisObject(this);
            audioSources = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {

            if (!audioSources[index].isPlaying)
            {
                audioSources[index].Play();
            }



        }

        public void StopSound(int index)
        {
            if (audioSources[index].isPlaying)
            {
                audioSources[index].Stop();

            }
        }

        public void JumpSound()
        {
            audioSources[1].PlayOneShot(audioClip);
        }



    }

}
