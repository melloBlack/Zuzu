using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Concretes.Pools;

namespace Zuzu.Concretes.Controllers
{
    public class RockController : EnemyController
    {

        public override void SetEnemyPool()
        {
            RockPool.Instance.Set(this);
        }
    }
}

