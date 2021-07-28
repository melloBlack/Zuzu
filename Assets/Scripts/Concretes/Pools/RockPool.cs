using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Abstracts.Pools;
using Zuzu.Concretes.Controllers;

namespace Zuzu.Concretes.Pools
{
    public class RockPool : GenericPool<RockController>
    {
        public static RockPool Instance { get; private set; }

        protected override void SingletonObject()
        {
            if(Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
} 


