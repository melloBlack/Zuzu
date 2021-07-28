using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    [SerializeField] AudioSource _audioSourceBulletFire;
    [SerializeField] AudioSource _audioSourceShotRedFlap;
    [SerializeField] AudioSource _audioSourceShotRock;
    [SerializeField] AudioSource _audioSourceZuzuOver;
    [SerializeField] AudioSource _audioSourceKrystal;
    public static SoundController Instance { get; private set; }
    private void Awake()
    {
        SingletonThisGameObject();
    }
    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void BulletFire()
    {
        _audioSourceBulletFire.Play();
    }
    public void ShotRedFlap()
    {
        _audioSourceShotRedFlap.Play();
    }
    public void ShotRock()
    {
        _audioSourceShotRock.Play();
    }
    public void ZuzuOver()
    {
        _audioSourceZuzuOver.Play();
    }

    public void Krystal()
    {
        _audioSourceKrystal.Play();
    } 

}
