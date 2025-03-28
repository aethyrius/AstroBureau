using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet
{
    public string planetName;
    public float size;

    public List<string> terrains;
    public List<string> waters;

    public List<string> gases;
    public List<string> liquids;

    public string assignedSolarSystem;

    public Planet()
    {
        planetName = "";
        size = 0;

        terrains = new List<string>();
        waters = new List<string>();

        gases = new List<string>();
        liquids = new List<string>();

        assignedSolarSystem = "";
    }
}
