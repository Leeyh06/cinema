using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerClicker : MonoBehaviour
{
    public GameObject PlayerBox; // 플레이어 오브젝트
    public float Mun;

    private Vector3 PlayerPos; // 플레이어 포지션

    // Use this for initialization
    private void Start()
    {
        //string text = ButtonClicked.textdata;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveCameraleft(PlayerBox);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveCameraRight(PlayerBox);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveCameraForward(PlayerBox);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveCameraBack(PlayerBox);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Enter");
            Debug.Log(this.transform.position);

            //FindObjectOfType<Button>()                .transform.position;
            //this.transform.position.Equals()
            //GetComponentsInParent<Button>
            //this.transform.position;
        }
    }

    private void MoveCameraleft(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.left * 1500 * Time.deltaTime;
    }

    private void MoveCameraRight(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.right * 1500 * Time.deltaTime;
    }

    private void MoveCameraForward(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.up * 1200 * Time.deltaTime;
    }

    private void MoveCameraBack(GameObject CameraBox)
    {
        CameraBox.transform.position += Vector3.down * 1200 * Time.deltaTime;
    }
}