using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitStarMap : MonoBehaviour
{
    [SerializeField] GameObject prefabPlanet;
    [SerializeField] public Planet [] planets;
    [SerializeField] SunLigth sun;
    [SerializeField] float distanceBetweenPlanets;
    [SerializeField] private Material [] inMat;
    public FocusPlanet planetsOnScene;

    void Awake()
    {
        Instantiate(sun, transform.parent);
        Vector3 posPlanet = sun.transform.position;

        for (int i = 0; i < planets.Length; i++)
        {
            planets[i] = Instantiate(prefabPlanet, sun.transform.parent).gameObject.GetComponent<Planet>();
            planets[i].transform.position = new Vector3(sun.transform.position.x + (distanceBetweenPlanets * (i + 1))
                , sun.transform.position.y, sun.transform.position.z);
            planets[i].SetUp((i + 1) * 20, Random.Range(1.0f, 6.0f), Random.Range(3.0f, 10.0f),
            Random.Range(0.1f, 0.9f), inMat[Random.Range(0, inMat.Length)]);

        }
        planetsOnScene.SetPlanetsList(planets, planets.Length);
    }

    private void Update()
    {
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].UpdatePlanetData();
        }
    }
}
