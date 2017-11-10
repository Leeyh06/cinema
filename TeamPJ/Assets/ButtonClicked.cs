using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{
    public static string Textdata;
    private bool checkedtest = false;

    public void Onclicked()
    {
        Textdata = GetComponentInParent<Text>().text + GetComponentInChildren<Text>().text;

        if (checkedtest)
        {
            //            GetComponent<Button>().renderer.particleSystem.tag.
            GetComponentInChildren<Text>().color = Color.black;
            checkedtest = false;
        }
        else
        {
            checkedtest = true;
            GetComponentInChildren<Text>().color = Color.white;
        }

        Debug.Log(Textdata);
        if (SceneManager.GetActiveScene().name.Equals("SelectSeat"))
        {
            SceneManager.LoadScene(2);
        }
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