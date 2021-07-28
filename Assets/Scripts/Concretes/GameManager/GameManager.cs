using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float score;
    public static GameManager Instance { get; private set; }
    public static bool Pause { get; private set; }

    public event Action<float> OnscoreChange;

    private void Awake()
    {
        SingletonThisGameObject();
        PauseGame();
    }


    private void Update()
    {
        if (Pause)
        {
            score = 0;
        }
        else
        {
            score += Time.deltaTime;
            OnscoreChange?.Invoke(score);
        }        
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

    public void RestartGame()
    {
        score = 0;
        Pause = true;
        StartCoroutine(RestartGameAsync());
    }

    private IEnumerator RestartGameAsync()
    {

        yield return SceneManager.LoadSceneAsync("Game");
    }
    public void StartGame()
    {
        score = 0;
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Player.GetComponent<Rigidbody2D>().simulated = true;
        Pause = false;
    }

    public void PauseGame()
    {
        //Oyun burada duraklatılacak
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        Player.GetComponent<Rigidbody2D>().simulated = false;
        Pause = true;
    }
}
