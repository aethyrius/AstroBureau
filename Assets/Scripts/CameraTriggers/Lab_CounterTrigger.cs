using Cinemachine;
using UnityEngine;

public class Lab_CounterTrigger : MonoBehaviour
{
    public CinemachineVirtualCamera counterCam, labCam;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Vector2 playerPosition = other.transform.position;
            Vector2 triggerPosition = transform.position;

            if (playerPosition.x > triggerPosition.x)
            {
                // Entering from the counter
                labCam.Priority = 10;
                counterCam.Priority = 0;
            } else
            {
                // Entering from the lab
                counterCam.Priority = 10;
                labCam.Priority = 0;
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
                // Exiting from the counter
                labCam.Priority = 10;
                counterCam.Priority = 0;
            } else
            {
                // Exiting from the lab
                counterCam.Priority = 10;
                labCam.Priority = 0;
            }
        }
    }
}