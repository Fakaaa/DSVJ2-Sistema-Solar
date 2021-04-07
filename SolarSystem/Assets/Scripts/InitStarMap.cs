using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitStarMap : MonoBehaviour
{
    [SerializeField] GameObject prefabPlanet;
    [SerializeField] Meteor metorPrefab;
    [SerializeField] public Planet[] planets;
    [SerializeField] public List<Meteor> meteors;
    [SerializeField] SunLigth sun;
    [SerializeField] float distanceBetweenPlanets;
    [SerializeField] private Material[] inMat;
    public FocusPlanet planetsOnScene;

    [SerializeField] int amountMeteorsIncoming;
    [SerializeField] float speedMeteors;
    [SerializeField] float timeToMeteorRain;
    [SerializeField] float timer;
    [SerializeField] bool stillCreatingMeteors;

    [SerializeField] bool weirdMode;

    void Awake()
    {
        Instantiate(sun, transform.parent);
        Vector3 posPlanet = sun.transform.position;
        stillCreatingMeteors = true;

        for (int i = 0; i < planets.Length; i++)
        {
            planets[i] = Instantiate(prefabPlanet, sun.transform.parent).gameObject.GetComponent<Planet>();
            planets[i].transform.position = new Vector3(sun.transform.position.x + (distanceBetweenPlanets * (i + 1))
                , sun.transform.position.y + (Random.Range(-10, 10)), sun.transform.position.z);
            if (!weirdMode)
            {
                planets[i].weirdMode = false;
                planets[i].SetUp((i + 1) * 20, Random.Range(1.0f, 6.0f), Random.Range(7.0f, 20.0f),
                Random.Range(0.1f, 0.9f), inMat[Random.Range(0, inMat.Length)]);
            }
            else
            {
                planets[i].weirdMode = true;
                planets[i].SetUp((i + 1) * 20, Random.Range(1.0f, 6.0f), Random.Range(7.0f, 20.0f),
                Random.Range(1.0f, 7.0f), inMat[Random.Range(0, inMat.Length)]);
            }

        }
        planetsOnScene.SetPlanetsList(planets, planets.Length);
    }

    private void Update()
    {
        for (int i = 0; i < planets.Length; i++)
        {
            planets[i].UpdatePlanetData();
        }

        timer += Time.deltaTime;

        if (timer >= timeToMeteorRain && stillCreatingMeteors)
        {
            timer = 0;
            for (int i = 0; i < amountMeteorsIncoming; i++)
            {
                meteors.Add(Instantiate(metorPrefab, new Vector3(Random.Range(-1000, 1000), Random.Range(-50, 50), Random.Range(-1000, 1000)), Quaternion.identity));
            }
            for (int i = 0; i < meteors.Count; i++)
            {
                meteors[i].SetMeteorVariety(new Vector3(Random.Range(1, 4), Random.Range(3, 5), Random.Range(1, 10)));
            }
            stillCreatingMeteors = false;
        }

        for (int i = 0; i < meteors.Count; i++)
        {
            if (meteors[i] != null)
            {
                if (weirdMode)
                {
                    for (int j = 0; j < planets.Length; j++)
                    {
                        meteors[i].MoveMeteor(speedMeteors, planets[j].transform.position);
                    }
                }
                else
                    meteors[i].MoveMeteor(speedMeteors, sun.transform.position);

                if (meteors[i].crash)
                {
                    GameObject.Destroy(meteors[i].gameObject);
                    meteors.RemoveAt(i);
                }
            }
        }

    }
}
