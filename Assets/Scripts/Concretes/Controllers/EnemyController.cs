using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Abstracts.Controllers;
using Zuzu.Concretes.Pools;

namespace Zuzu.Concretes.Controllers
{
    public abstract class EnemyController : LifeCycleController
    {
        public override void KillGameObject()
        {
            _currentTime = 0;
            //RockPool.Instance.Set(this);
            SetEnemyPool();
        }

        public abstract void SetEnemyPool();
    }
}