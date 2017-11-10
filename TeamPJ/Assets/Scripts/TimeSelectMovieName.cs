using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeSelectMovieName : MonoBehaviour
{
    Text movieName;
    //public GameObject loadedMovieName;

    void Start()
    {
        //티켓팅 인포라는 게임오브젝트를 불러와서
        //loadedMovieName = GameObject.Find("TicketingInfo");

        //거기에 저장된 영화 이름을 가져오기
        //loadedMovieName.GetComponent<TicketingInfo>();

        if (SceneManager.GetActiveScene().isLoaded)
        {
            movieName = GetComponent<Text>();
            if (PlayerPrefs.HasKey("MovieName"))
            {
                movieName.text = PlayerPrefs.GetString("MovieName");
            }
            //movieName.text = loadedMovieName.;
        }
    }

    void Update()
    {
    }
}