using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float radiusPlanet;
    [SerializeField] private float rotSpeedPlanet;
    [SerializeField] private float traslationSpeedPlanet;
    [SerializeField] private float scalePlanet;
    [SerializeField] private float anglePlanet;

    [SerializeField] public bool weirdMode;

    private MeshRenderer aux;
    void Update()
    {
        Vector3 v3 = Vector3.zero;
        anglePlanet += traslationSpeedPlanet * Time.deltaTime;

        v3.x = radiusPlanet * Mathf.Cos(anglePlanet);
        if(weirdMode)
            v3.y = radiusPlanet * Mathf.Sin(anglePlanet / 8);
        v3.z = radiusPlanet * Mathf.Sin(anglePlanet);

        transform.position = v3;
        transform.Rotate(Vector3.up * Time.deltaTime * rotSpeedPlanet);
    }

    public void SetUp(float radius, float scale, float rotSpeed, float transSpeed, Material newMat)
    {
        radiusPlanet = radius;
        scalePlanet = scale;
        rotSpeedPlanet = rotSpeed;
        traslationSpeedPlanet = transSpeed;
        anglePlanet = 0;

        aux = gameObject.GetComponent<MeshRenderer>();
        aux.material = newMat;
    }

    public void UpdatePlanetData()
    {
        transform.localScale = Vector3.one * scalePlanet;
    }
}
