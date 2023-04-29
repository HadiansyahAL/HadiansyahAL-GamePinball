using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button creditButton;
    public Button exitButton;
    



    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(CreditGame);
        exitButton.onClick.AddListener(ExitGame);
    }
    private void PlayGame()
    {
        SceneManager.LoadScene("Pinball");
    }

    private void CreditGame()
    {
        SceneManager.LoadScene("Credit");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
