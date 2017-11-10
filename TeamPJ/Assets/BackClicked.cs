using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackClicked : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    public void BackButtonClikced()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}