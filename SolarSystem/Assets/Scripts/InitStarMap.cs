using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitStarMap : MonoBehaviour
{
    [SerializeField] Planet [] planets;
    [SerializeField] SunLigth sun;
    [SerializeField] float distanceBetweenPlanets;
    void Start()
    {
        Instantiate(sun, transform.parent);
        Vector3 posPlanet = sun.transform.position;

        for (int i = 1; i < planets.Length; i++)
        {
            posPlanet.x = transform.position.x + (distanceBetweenPlanets * i);
            Instantiate(planets[i], posPlanet, Quaternion.identity ,transform.parent);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
