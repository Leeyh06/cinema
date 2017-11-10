using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieNameStorage : MonoBehaviour
{
    public static string movieName;

    private void Start()
    {
        DontDestroyOnLoad(this);
        movieName = NNN.Button.movieNamee;
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(movieName); //안됨!!
    }
}