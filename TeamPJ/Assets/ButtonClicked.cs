using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{
    public static string Textdata;
    private bool checkedtest;

    public void Onclicked()
    {
        Textdata = GetComponentInParent<Text>().text + GetComponentInChildren<Text>().text;
        GetComponentInChildren<Text>().color = Color.white;

        //this.

        SceneManager.LoadScene(2);
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}