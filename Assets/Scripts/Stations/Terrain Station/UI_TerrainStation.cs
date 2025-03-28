using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_TerrainStation : MonoBehaviour
{

    public GameObject waterOptions;
    public GameObject landOptions;

    private string _currentTerrain;

    private void Start()
    {
    }

    // This script will hold all of the button values/functions for the Terrain Station UI.
    public void WaterOptions()
    {
        landOptions.SetActive(false);
        waterOptions.SetActive(true);
    }

    public void LandOptions()
    {
        waterOptions.SetActive(false);
        landOptions.SetActive(true);
    }

    public void setCurrentTerrain(string terrain)
    {
        _currentTerrain = terrain;
    }

    public void Apply()
    {
        Debug.Log("Applied the terrains to the planet.");
    }
}
