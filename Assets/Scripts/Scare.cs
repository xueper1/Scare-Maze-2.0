using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scare : MonoBehaviour
{
    public Image displayImage;
    void Start()
    {
        displayImage.gameObject.SetActive(false);
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (displayImage != null && other.CompareTag("Player"))
        {
            displayImage.gameObject.SetActive(true);
        }
    }
}
