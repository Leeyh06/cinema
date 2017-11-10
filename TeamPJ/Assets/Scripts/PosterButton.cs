using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PosterButton : MonoBehaviour
{
    private Text movieName;
    private RectTransform rect;
    public static string movieNamee;

    //private Transform T;

    //private Vector3 LocalToGlobal(Vector3 v)
    //{
    //    T.localPosition = v;
    //    return T.position;
    //}

    public void Start()
    {
        rect = GetComponentInParent<RectTransform>();
    }

    //버튼이 클릭되면
    public void OnPosterClick()
    {
        //시간선택 화면을 로드해오고
        SceneManager.LoadScene("SelectTime");

        //자식으로 붙어있는 텍스트 컴포넌트에서 영화제목 텍스트를 읽어온 후 예매정보에 영화정보 기록하는 함수 실행.
        movieName = GetComponentInChildren<Text>();
        movieNamee = movieName.text;
        TicketingInfo.OnPosterButtonClicked();
    }
}