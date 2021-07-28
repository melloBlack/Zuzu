using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace Zuzu.Concretes.UIs
{
    public class DisplayScore : MonoBehaviour
    {
        TextMeshProUGUI _scoreText;
        private void Awake()
        {
            _scoreText = GetComponent<TextMeshProUGUI>();
        }

        private void Start()
        {
            GameManager.Instance.OnscoreChange += HandleOnScoreChange;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnscoreChange -= HandleOnScoreChange;
        }

        private void HandleOnScoreChange(float score=0)
        {
            if (score!=0)
            {
                _scoreText.text = $"{Mathf.Round(score)}";
            }
            else
            {
                _scoreText.text = "";
            }
            
        }
    }
}

