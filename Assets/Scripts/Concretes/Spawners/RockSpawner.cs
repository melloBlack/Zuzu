using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Abstracts.Spawners;
using Zuzu.Concretes.Controllers;
using Zuzu.Concretes.Pools;

namespace Zuzu.Concretes.Spawners
{
    public class RockSpawner : BaseSpawner
    {

        protected override void Spawn()
        {
            EnemyController poolenemy = RockPool.Instance.Get();
            poolenemy.transform.position = new Vector3(12f, poolenemy.transform.position.y, poolenemy.transform.position.z);
            
            poolenemy.gameObject.SetActive(true);
        }

    }
}

