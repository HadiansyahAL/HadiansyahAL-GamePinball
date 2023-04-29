using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerGameOver : MonoBehaviour
{
    public Collider ball;
    public GameObject gameOverCanvas;
    // public GameOverUIController gameOverUIController;


    private void OnTriggerEnter(Collider other) {
        if (other == ball)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
