using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Concretes.Combats;
using Zuzu.Concretes.Movements;

namespace Zuzu.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _input;
        LaunchFire _launchFire;
        AudioSource _audioSource;
        bool _isLeftMouseClicked;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchFire = GetComponent<LaunchFire>();
            _audioSource = GetComponent<AudioSource>();
            _input = new PcInputController();
        }

        private void Update()
        { 
            if (_input.LeftMouseClickDown)
            {
                _isLeftMouseClicked = true;
            }
            if (_input.RightMouseClickDown)
            {
                _launchFire.LaunchAction();
            }
        }

        private void FixedUpdate()
        {;
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _audioSource.Play();
                _isLeftMouseClicked = false;

            }
        }
    }
}

