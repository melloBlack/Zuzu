using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu.Abstracts.Controllers
{
    public abstract class LifeCycleController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime;
        bool _pauseGame;
        protected float _currentTime;

        private void Update()
        {
            _pauseGame = GameManager.Pause;

            _currentTime += Time.deltaTime;

            if (_currentTime > maxLifeTime)
            {
                KillGameObject();
            }

            if (_pauseGame)
            {
                KillGameObject();
            }

        }

        public abstract void KillGameObject();
    }

}
