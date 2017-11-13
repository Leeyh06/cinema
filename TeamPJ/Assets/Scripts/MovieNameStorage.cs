﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovieNameStorage : MonoBehaviour
{
    public static string movieName;

    private void Start()
    {
        DontDestroyOnLoad(this);
        movieName = NNN.Button.movieNamee;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().isLoaded)
        {
            movieName = PosterButton.movieNamee;
        }
    }
}