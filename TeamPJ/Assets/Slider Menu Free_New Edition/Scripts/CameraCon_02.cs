using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon_02 : MonoBehaviour
{

    public GameObject Player;

    public GameObject[] arr;

    int Mun;
    int i = 0;
    int SeatMinX = 0;

    Vector3 PlayerPos;


    // Use this for initialization
    void Start()
    {
        Debug.Log(Mun+"/"+arr.Length);

    }

    // Update is called once per frame
    void Update()
    {
        Move(Player);
        Debug.Log(i);
    }

    void Move(GameObject Player)
    {
       

        if (Input.GetKeyDown(KeyCode.LeftArrow) && i < arr.Length)
        {
            i += 1;
            GameObject Seatpos = arr[i];
            Player.transform.position = Seatpos.transform.position;
            Debug.Log("이동됬음 : " + Player.transform.position +"  " + i);
                        
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && i > 0)
        {
            i -= 1;
            GameObject Seatpos = arr[i];
            Player.transform.position = Seatpos.transform.position;
            Debug.Log("이동됬음 : " + Player.transform.position + "  " + i);
        }
    }
}
