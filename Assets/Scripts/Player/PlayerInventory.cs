using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public bool hasPlanet = false;
    public Planet currentPlanet;

    public GameObject templateStationObject;
    private TemplateStation _templateStation;

    private PlayerMovement _playerMovement;


    private void Start()
    {
        _templateStation = templateStationObject.GetComponent<TemplateStation>();
        _playerMovement = gameObject.GetComponent<PlayerMovement>();
    }

    // Template Station: Assigns the planet name and size.
    public void GivePlanetTemplate()
    {
        if (hasPlanet == false && _templateStation.nameText.text != "")
        {
            currentPlanet = new Planet();
            hasPlanet = true;

            // Assigns the new planet's name.
            currentPlanet.planetName = _templateStation.nameText.text;
            Debug.Log($"The player has been given a planet template with the name of {currentPlanet.planetName}.");

            // Assigns the new planet's size.
            currentPlanet.size = _templateStation.sizeSlider.value;
            Debug.Log($"{currentPlanet.planetName}'s size has been set to {currentPlanet.size} units.");

            _templateStation.templateUI.SetActive(false);
            _templateStation.nameText.text = "";
            _templateStation.promptUI.enabled = true;
            _playerMovement.canMove = true;

        } else if (_templateStation.nameText.text == "")
        {
            // Make into a UI change later
            Debug.Log("The planet must be given a name.");

        } else if (hasPlanet == true)
        {
            // Make into a UI change later
            Debug.Log("The player already has a template.");
        }
    }

    public void ApplyTerrains()
    {
        // Function for the Terrain Station button
    }
}
