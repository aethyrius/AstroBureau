using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balcony_LabTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera labCam, balconyCam;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Vector2 playerPosition = other.transform.position;
            Vector2 triggerPosition = transform.position;

            if (playerPosition.x > triggerPosition.x)
            {
                // Entering from the lab
                balconyCam.Priority = 10;
                labCam.Priority = 0;
            }
            else
            {
                // Entering from the balcony
                labCam.Priority = 10;
                balconyCam.Priority = 0;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Vector2 playerPosition = other.transform.position;
            Vector2 triggerPosition = transform.position;

            if (playerPosition.x < triggerPosition.x)
            {
                // Exiting from the lab
                balconyCam.Priority = 10;
                labCam.Priority = 0;
            }
            else
            {
                // Exiting from the balcony
                labCam.Priority = 10;
                balconyCam.Priority = 0;
            }
        }
    }
}
