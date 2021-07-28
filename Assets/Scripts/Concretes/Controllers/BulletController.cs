using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Abstracts.Controllers;

namespace Zuzu.Concretes.Controllers
{
    public class BulletController : LifeCycleController
    {
        [SerializeField] Transform _crystal;
        SoundController _soundController;

        private void Start()
        {
            _soundController = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
            _soundController.BulletFire();

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            EnemyController enemy = collision.GetComponent<EnemyController>();
            int chanceNumber = Random.Range(1, 6);
            if (enemy != null)
            {
                if (enemy.tag != "RedFlap")
                {
                    _soundController.ShotRock();
                    switch (chanceNumber)
                    {
                        case 2:
                            Instantiate(_crystal, this.transform.position, _crystal.transform.rotation);
                            break;
                        case 4:
                            Instantiate(_crystal, this.transform.position, _crystal.transform.rotation);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    _soundController.ShotRedFlap();   
                }
                enemy.KillGameObject();  
            }
            KillGameObject();
        }
        public override void KillGameObject()
        {
            Destroy(this.gameObject);
        }
    }
}

