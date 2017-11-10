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