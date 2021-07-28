using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu.Concretes.Combats
{
    public class Dead : MonoBehaviour
    {
        private bool _isDead;
        public bool IsDead => _isDead;

        public event System.Action OnDead;


        public void StartGame()
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().StartGame();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
                GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>().ZuzuOver();
                _isDead = true;
                OnDead?.Invoke();

        }

    }
}

