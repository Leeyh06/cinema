using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StorageReset : MonoBehaviour
{
    void Start()
    {
        if (SceneManager.GetActiveScene().isLoaded)
        {
            if (PlayerPrefs.HasKey("MovieName"))
            {
                PlayerPrefs.SetString("MovieName", null);
            }
        }
    }
}