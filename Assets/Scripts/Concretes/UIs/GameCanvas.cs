using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Concretes.Combats;

namespace Zuzu.Concretes.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            GameManager.Instance.RestartGame();
        }
    }
}

