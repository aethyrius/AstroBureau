using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationStation : MonoBehaviour
{
    private Canvas _promptUI;
    private void Start()
    {
        _promptUI = GetComponentInChildren<Canvas>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _promptUI.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _promptUI.enabled = false;
        }
    }
}
