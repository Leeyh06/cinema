using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private Text movieName;
    public static string movieNamee;

    public void OnPosterClick()
    {
        SceneManager.LoadScene(1);
        movieName = GetComponentInChildren<Text>();
        movieNamee = movieName.text;
    }
}