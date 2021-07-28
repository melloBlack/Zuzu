using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zuzu.Concretes.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButtonClick()
        {
            GameManager.Instance.RestartGame();
        }

        public void NoButtonClick()
        {
            //Ana menüye dön
        }
    }
}

