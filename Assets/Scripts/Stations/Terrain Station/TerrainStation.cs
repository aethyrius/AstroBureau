using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainStation : MonoBehaviour
{
    public Canvas promptUI;
    public GameObject terrainUI;

    public GameObject player;
    private PlayerMovement _playerMovement;

    private bool _playerIsTouching;

    private void Start()
    {
        _playerMovement = player.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (terrainUI.activeSelf)
            {
                terrainUI.SetActive(false);
                _playerMovement.canMove = true;

                if (_playerIsTouching)
                {
                    promptUI.enabled = true;
                }
                else if (!_playerIsTouching)
                {
                    promptUI.enabled = false;
                }
            }
            else if (!terrainUI.activeSelf && promptUI.enabled)
            {
                terrainUI.SetActive(true);
                promptUI.enabled = false;
                _playerMovement.canMove = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playerIsTouching = true;
            promptUI.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playerIsTouching = false;
            promptUI.enabled = false;
        }
    }
}
