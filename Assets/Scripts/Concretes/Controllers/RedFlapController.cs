using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Concretes.Pools;

namespace Zuzu.Concretes.Controllers
{
    public class RedFlapController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedFlapPool.Instance.Set(this);
        }
    }
}
