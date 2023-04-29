using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRampController : MonoBehaviour
{
    public Collider ball;
    public float score;

    public ScoreManager scoreManager;


    private void OnTriggerEnter(Collider other) {
        if (other == ball)
        {
            scoreManager.AddScore(score);
        }
    }
}
