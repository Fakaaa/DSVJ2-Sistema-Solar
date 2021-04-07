using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendPlanets : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Color blendPlanet = gameObject.GetComponent<MeshRenderer>().material.color;

        Debug.Log("Entro ");
        blendPlanet.a = 0.5f;
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(blendPlanet.r, blendPlanet.g, blendPlanet.b, blendPlanet.a);

        Debug.Log("RGBA Planet: " + gameObject.GetComponent<MeshRenderer>().material.color);
    }
    public void OnTriggerExit(Collider other)
    {
        Color blendPlanet = gameObject.GetComponent<MeshRenderer>().material.color;

        Debug.Log("Salio ");
        blendPlanet.a = 1.0f;
        gameObject.GetComponent<MeshRenderer>().material.color = new Color(blendPlanet.r, blendPlanet.g, blendPlanet.b, blendPlanet.a);

        Debug.Log("RGBA Planet: " + gameObject.GetComponent<MeshRenderer>().material.color);
    }
}
