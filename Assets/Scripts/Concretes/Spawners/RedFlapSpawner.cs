using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Abstracts.Pools;
using Zuzu.Abstracts.Spawners;
using Zuzu.Concretes.Controllers;
using Zuzu.Concretes.Pools;

namespace Zuzu.Concretes.Spawners
{
    public class RedFlapSpawner : BaseSpawner
    {
        protected override void Spawn()
        {
            EnemyController newEnemy = RedFlapPool.Instance.Get();
            newEnemy.transform.position = new Vector3 (12f, newEnemy.transform.position.y, newEnemy.transform.position.z);
            newEnemy.gameObject.SetActive(true);
        }
    }
}

