using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovieNameStorage : MonoBehaviour
{
    public static string movieName;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    private void Update()
    {
        //  if (SceneManager.GetActiveScene().isLoaded)
        //  {
        //      movieName = Button.movieNamee;
        //      Debug.Log(movieName);
        //  }
    }
}