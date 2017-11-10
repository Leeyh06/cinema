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
    private Button childrenButton;

    public void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        childrenButton = GetComponentInChildren<Button>();
    }

    public void Update()
    {
        //Debug.Log(rectTransform.position.x);
        if (rectTransform.position.x < expandMax && rectTransform.position.x > expandMin)
        {
            rectTransform.localScale = new Vector3(0.375f, 1.5f, 1.5f);
            childrenButton.enabled = true;
        }
        else
        {
            rectTransform.localScale = new Vector3(0.25f, 1f, 1f);
            //childrenButton.enabled = false;
        }
    }
}