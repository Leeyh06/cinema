using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRValueControl : MonoBehaviour
{
    public Scrollbar scrollbar;
    public float buttonDownValue = 0.1f;

    public void Update()
    {
        //1. 버튼을 누를 때
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            scrollbar.value += buttonDownValue;
            Debug.Log("right");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            scrollbar.value -= buttonDownValue;
        }

        //2. 조이스틱 입력 받을 때

        //3. 시선이 끝으로 갈 때
    }
}