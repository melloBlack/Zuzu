using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu.Concretes.Controllers
{
    public class BackgroundSound : MonoBehaviour
    {
        AudioSource _audioSource;
        static bool _isFirstTime = true;

        private void Awake()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        void Start()
        {
            if (_isFirstTime)
            {
                SpawnBackgroundSound();
                _isFirstTime = false;
            }
            else
            {
                Destroy(this.gameObject);
            }

        }


        private void SpawnBackgroundSound()
        {
            _audioSource.Play();
            DontDestroyOnLoad(this.gameObject);
        }

    }
}

