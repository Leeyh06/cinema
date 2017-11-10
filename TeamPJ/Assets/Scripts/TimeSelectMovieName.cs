using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeSelectMovieName : MonoBehaviour
{
    Text movieName;

    void Start()
    {
        if (SceneManager.GetActiveScene().isLoaded)
        {
            movieName = GetComponent<Text>();
            if (PlayerPrefs.HasKey("MovieName"))
            {
                movieName.text = PlayerPrefs.GetString("MovieName");
            }
        }
    }
}