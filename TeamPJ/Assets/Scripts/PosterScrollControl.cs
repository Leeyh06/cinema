using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosterScrollControl : MonoBehaviour
{
    public Scrollbar scrollbar;
    public float buttonCount = 4;
    private float buttonValue = 1;

    public void Start()
    {
        buttonValue = 1 / buttonCount;
    }

    public void OnButton1()
    {
        scrollbar.value = buttonValue * 0;
    }

    public void OnButton2()
    {
        scrollbar.value = buttonValue * 1;
    }

    public void OnButton3()
    {
        scrollbar.value = buttonValue * 2;
    }

    public void OnButton4()
    {
        scrollbar.value = buttonValue * 3;
    }

    public void OnButton5()
    {
        scrollbar.value = buttonValue * 4;
    }
}