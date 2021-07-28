using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zuzu.Concretes.Combats;

namespace Zuzu.Concretes.Controllers
{

    public class KrystalController : MonoBehaviour
    {
        [SerializeField] Sprite[] _model;

        [SerializeField] float currentTime=3;
        float _time;
        SoundController _soundController;
        SpriteRenderer _renderer;

        private void Awake()
        {
            _renderer = GetComponent<SpriteRenderer>();
            _soundController = GameObject.FindGameObjectWithTag("SoundController").GetComponent<SoundController>();
            _soundController.Krystal();

        }
        private void Start()
        {
            int chanceNumber = Random.Range(1, 4);
            switch (chanceNumber)
            {
                case 1:
                    _renderer.sprite = _model[0];
                    break;
                case 2:
                    _renderer.sprite = _model[1];
                    break;
                case 3:
                    _renderer.sprite = _model[2];
                    break;
                default:
                    break;
            }
        }
        // Update is called once per frame
        void Update()
        {
            _time += Time.deltaTime;
            if(_time > currentTime)
            {
                Destroy(this.gameObject);
            }
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Player")
            {
                collision.gameObject.GetComponent<LaunchFire>().EarnAmmo();
                _soundController.Krystal();
                Destroy(this.gameObject);
            }
        }
    }
}

