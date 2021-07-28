using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu.Abstracts.Spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2.5f, 5f)]
        [SerializeField] float maxSpawnTime;
        [Range(0.5f, 2.5f)]
        [SerializeField] float minSpawnTime;

        float _currentSpawnTime;
        float _timeBoundry;
        bool _pause;

        private void Start()
        {
            
            ResetTimes();
        }
        private void Update()
        {
            _pause = GameManager.Pause;
            if (!_pause)
            {
                _currentSpawnTime += Time.deltaTime;
                if (_currentSpawnTime > _timeBoundry)
                {
                    Spawn();
                    ResetTimes();
                }
            }
        }

        protected abstract void Spawn();


        private void ResetTimes()
        {
            _currentSpawnTime = 0;
            _timeBoundry = Random.Range(minSpawnTime, maxSpawnTime);
        }
    }

}
