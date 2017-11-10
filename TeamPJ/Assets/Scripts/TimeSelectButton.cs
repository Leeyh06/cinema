using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeSelectButton : MonoBehaviour
{
    /*
    private Text time;
    private Button button;
    private int startTime;
    private int endTime;
    private int runningTime = 118;
    private int startHour;
    private int startMinute;
    private int endHour;
    private int endMinute;

    public void Start()
    {
         time = GetComponentInChildren<Text>();
         button = GetComponent<Button>();

         for (int i = 1; i <= 2; i++)
         {
             if (button.name.Contains("" + i))
             {
                 startTime = Random.Range(600, 631);
                 endTime = startTime + runningTime;

                 startHour = startTime / 60;
                 startMinute = startTime % 60;

                 endHour = endTime / 60;
                 endMinute = endTime % 60;

                 if (time.name == "StartTimeText")
                 {
                     time.text = startTime + " : " + startMinute;
                 }
                 if (time.name == "EndTimeText")
                 {
                     time.text = endTime + " : " + endMinute;
                 }
             }
         }

        if (SceneManager.GetActiveScene().isLoaded)
        {
        }
    }
    */

    public Text startTime;
    public Text endTime;

    public void OnClickButton()
    {
        TicketingInfo.OnTimeButtonClicked(startTime.text, endTime.text);
        SceneManager.LoadScene("SelectSeat");
    }
}