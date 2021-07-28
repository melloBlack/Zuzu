using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundContorller : MonoBehaviour
{
    public static BackgroundContorller Instance { get; private set; }

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
}
