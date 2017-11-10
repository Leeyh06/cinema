using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeSelectButton : MonoBehaviour
{
    public Text startTime;
    public Text endTime;

    public void OnClickButton()
    {
        TicketingInfo.OnTimeButtonClicked(startTime.text, endTime.text);
        SceneManager.LoadScene("SelectSeat");
    }
}