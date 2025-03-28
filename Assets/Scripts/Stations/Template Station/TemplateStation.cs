using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TemplateStation : MonoBehaviour
{
    public Canvas promptUI;
    public GameObject templateUI;
    public Slider sizeSlider;
    public TMP_InputField nameText;

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
            if (templateUI.activeSelf && !nameText.isFocused)
            {
                templateUI.SetActive(false);
                _playerMovement.canMove = true;
                nameText.text = "";

                if (_playerIsTouching)
                {
                    promptUI.enabled = true;
                } else if (!_playerIsTouching)
                {
                    promptUI.enabled = false;
                }
            }
            else if (!templateUI.activeSelf && promptUI.enabled)
            {
                templateUI.SetActive(true);
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