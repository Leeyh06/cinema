using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public Text score;
    private int scoreText = 0;

    private void OnCollisionEnter(Collision collision)
    {
        scoreText += 1;
        score.text = "" + scoreText;
    }
}