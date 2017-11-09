using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContor : MonoBehaviour {

    public GameObject PlayerBox; // 플레이어 오브젝트
    public float Mun;

    Vector3 PlayerPos; // 플레이어 포지션



    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveCameraleft(PlayerBox);
        }

        if (!Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveCameraRight(PlayerBox);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && !Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveCameraForward(PlayerBox);
        }

        if (!Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveCameraBack(PlayerBox);
        }

    }

    void MoveCameraleft(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.left * Mun * Time.deltaTime;
    }

    void MoveCameraRight(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.right * Mun * Time.deltaTime;
    }

    void MoveCameraForward(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.forward * Mun * Time.deltaTime;
    }

    void MoveCameraBack(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.back * Mun * Time.deltaTime;
    }



}
