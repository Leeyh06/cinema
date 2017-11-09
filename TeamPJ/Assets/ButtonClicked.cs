using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{
    public Text gettext1, gettext2;

    public void Onclicked()
    {
        gettext1 = GetComponentInParent<Text>();
        gettext2 = GetComponentInChildren<Text>();

        Debug.Log(gettext1.text + gettext2.text);

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