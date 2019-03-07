using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayPickRight()
    {
        SceneManager.LoadScene("ChooseShapes");
    }

    public void PlayCardGame()
    {
        SceneManager.LoadScene("CardGameScene");
    }

    public void PlayFunkyChecker()
    {
        SceneManager.LoadScene("FunkyCheckers");
    }

    public void PlayVisualNovel()
    {
        SceneManager.LoadScene("WelcomeNeighbor");
    }

    public void ViewGarden()
    {
        SceneManager.LoadScene("ViewGarden");
    }
}
