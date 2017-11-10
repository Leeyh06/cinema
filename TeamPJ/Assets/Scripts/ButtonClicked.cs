using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClicked : MonoBehaviour
{
    public static string textdata;
    private bool checkedtest = false;

    public void Onclicked()
    {
        textdata = GetComponentInParent<Text>().text + GetComponentInChildren<Text>().text;

        if (checkedtest)
        {//버튼선택된 상태에서 한번더 클릭하면 활성화
            GetComponentInChildren<Text>().color = Color.black;
            checkedtest = false;
        }
        else
        {//자리버튼 선택시 활성화
            checkedtest = true;

            //GetComponent<Button>()
            //textdata

            GetComponentInChildren<Text>().color = Color.white;
        }

        Debug.Log(textdata);
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