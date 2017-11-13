using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SeatManager : MonoBehaviour
{
    private string Seat;
    private void Awake()
    {
        GameObject gameObject = GameObject.Find("B11");

        Button b1 = gameObject.GetComponent<Button>();
        //b1.enabled = false;
    }
    // Use this for initialization
    void Start()
    {
        Seat = "B11 C13 A14 F1";
        string[] findText = Seat.Split(' ');

        //FindObjectOfType
        //GameObject findobject = GameObject.FindWithTag(findText[0]);
        //Debug.Log(findText[0] + findText[1]);

        for (int i = 0; i < findText.Length; i++)
        {
            //GameObject.Find(findText[i]).SetActive(false);
            //GameObject.Find(findText[i]).GetComponentInChildren<Image>.color = Color.blue;
            //GameObject.Find(findText[i]).GetComponentInChildren<Image>.color = Color.black;
            //GameObject.Find(findText[i]).GetComponentInChildren<Text>.color = Color.black;

            GameObject.Find(findText[i]).GetComponent<Button>().enabled = false;
            GameObject.Find(findText[i]).GetComponent<Image>().color = Color.black;
        }

        //GameObject.Find(Seat).enabled = false;

        //GameObject.Find(Seat).col

        //GameObject.FindGameObjectWithTag(Seat).isStatic = false;
        //GameObject.FindWithTag(Seat).isStatic = false;

        //GetComponentInChildren<Button>().GetComponentInChildren<Button>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}