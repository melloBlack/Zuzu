using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Concretes.Controllers;
using UnityEngine.UI;

namespace Zuzu.Concretes.Combats
{
    public class LaunchFire : MonoBehaviour
    {
        [SerializeField] BulletController _bulletController;
        [SerializeField] Transform _bulletTransform;
        [SerializeField] GameObject bulletParent;
        [SerializeField] GameObject fireEffect;
        [SerializeField] Image[] _images;
        [SerializeField] float cooldownBullet = 1f;

        int _ammo=4;
        float _currentCoolDown;
        bool _canLaunch = false;

        private void Start()
        {
            for (int i = 0; i < _images.Length; i++)
            {
                _images[i].gameObject.SetActive(true);
            }
        }

        private void Update()
        {
            _currentCoolDown += Time.deltaTime;
            if (_currentCoolDown >cooldownBullet)
            {
                _canLaunch = true;
                _currentCoolDown = 0;
            }
        }
        public void LaunchAction()
        {
            if(_canLaunch)
            {
                if (_ammo > 0)
                {
                    StartCoroutine(FireEffect());
                    for (int i =0; i < _images.Length; i++)
                    {
                        if (i<_ammo)
                        {
                            _images[i].gameObject.SetActive(true);
                        }
                        else
                        {
                            _images[i].gameObject.SetActive(false);
                        }
                        
                    }
                } 
            }
        }

        public void EarnAmmo()
        {
            _ammo=4;
            for (int i = 0; i < _images.Length; i++)
            {
                _images[i].gameObject.SetActive(true);
            }
        }

        IEnumerator FireEffect()
        {
            _canLaunch = false;
            _ammo--;
            fireEffect.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            BulletController newBulletController = Instantiate(_bulletController, _bulletTransform.position, _bulletTransform.rotation);
            newBulletController.transform.parent = bulletParent.transform;
            yield return new WaitForSeconds(1f);
            fireEffect.SetActive(false);
        }
    }
}

