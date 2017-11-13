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
        int count = 1;

        if (!this.enabled) //이미 예약이 되있을때
        {
            Debug.Log("자리가꽉참");
        }
        else
        {
            //자리가 비었을때
        }

        if (checkedtest)
        {//버튼선택된 상태에서 한번더 클릭하면 실행
            GetComponentInChildren<Text>().color = Color.black; //텍스트 색깔
            GetComponent<Image>().color = Color.white; //배경색깔
            checkedtest = false;
            count++;
            //textdata.Remove(textdata.Contains(GetComponentInParent<Text>().text + " " + GetComponentInChildren<Text>().text));
        }
        else
        {//자리버튼 선택시 실행
            checkedtest = true;
            GetComponent<Image>().color = Color.blue;
            GetComponentInChildren<Text>().color = Color.white;
            GetComponent<Button>().enabled = false;
            this.enabled = false; //버튼비활성화
            count--;
            textdata += GetComponentInParent<Text>().text + " " + GetComponentInChildren<Text>().text + " ";
        }

        //Debug.Log(textdata);

        string[] seatnum = textdata.Split(' ');

        if (seatnum[0] == "A")
        {
            //Vector3 x = new Vector3(1, 0, 0);
            //PlayerBox.transform.position = x;
        }

        if (seatnum[1] == "1")
        {
        }

        if (count == 0)
        {
            if (SceneManager.GetActiveScene().name.Equals("SelectSeat"))
            {
                SceneManager.LoadScene(2);
            }
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