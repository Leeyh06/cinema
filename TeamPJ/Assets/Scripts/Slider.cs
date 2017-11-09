using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//using UnityEngine.XR;

public class Slider : MonoBehaviour
{
    private RectTransform rectTransform;
    private float expandMin = -3.0f;
    private float expandMax = 3.0f;

    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void Update()
    {
        //Debug.Log(rectTransform.position.x);
        if (rectTransform.position.x < expandMax && rectTransform.position.x > expandMin)
        {
            rectTransform.localScale = new Vector3(0.375f, 1.5f, 1.5f);
        }
        else
        {
            rectTransform.localScale = new Vector3(0.25f, 1f, 1f);
        }

        //if (Input.GetButtonDown("Fire1"))
        //{
        //    SceneManager.LoadScene(1);
        //}
    }
}