using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FollowMouse : MonoBehaviour
{
    private Camera mainCamera;
    public float speed = 2.0f;
    [SerializeField]


    void Start()
    {
        mainCamera = Camera.main;

    }
    


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }



}