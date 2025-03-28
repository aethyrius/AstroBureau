using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerInteraction : MonoBehaviour
{
    public Canvas buttonPrompt;

    public bool isInBox;

    private void Update()
    {
        if (isInBox)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            isInBox = true;
            buttonPrompt.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")){
            isInBox = false;
            buttonPrompt.enabled = false;
        }
    }
}
