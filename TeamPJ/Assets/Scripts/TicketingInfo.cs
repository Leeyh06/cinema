using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TicketingInfo : MonoBehaviour
{
    GameObject selectObject;

    const string movieNameString = "MovieName";
    const string startTimeString = "StartTime";
    const string endTimeString = "EndTime";

    void Start()
    {
        DontDestroyOnLoad(this);

        //씬이 새로 로드될 때마다
        // if (SceneManager.GetActiveScene().isLoaded)
        // {
        //     selectObject = GameObject.Find("Button");//버튼 오브젝트를 찾아서 데려옴.
        // }
    }

    void Update()
    {
        if (true)
        {
        }
    }

    //버튼 오브젝트가 클릭되었을 때
    public static void OnPosterButtonClicked()
    {
        //FileReader에 저장함.
        PlayerPrefs.SetString(movieNameString, PosterButton.movieNamee);
        //Debug.Log(PosterButton.movieNamee);
    }

    public static void OnTimeButtonClicked(string startTime, string endTime)
    {
        PlayerPrefs.SetString(startTimeString, startTime);
        PlayerPrefs.SetString(endTimeString, endTime);
    }
}