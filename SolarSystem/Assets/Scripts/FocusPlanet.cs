using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusPlanet : MonoBehaviour
{
    //---
    [SerializeField] GameObject ship;
    [SerializeField] Vector3 offset;
    //---
    public List<GameObject> planetList;
    private int index = 0;
    private Vector3 auxOffset;
    private bool onShip;
    //---

    private void Start()
    {
        auxOffset = offset;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            onShip = false;
            index = 0;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            onShip = false;
            index = 1;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            onShip = false;
            index = 2;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            onShip = false;
            index = 3;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            onShip = false;
            index = 4;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            onShip = false;
            index = 5;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            onShip = false;
            index = 6;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            onShip = false;
            index = 7;
            offset *= 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            onShip = false;
            index = 8;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            onShip = true;
        }

    }
    void LateUpdate()
    {
        if(index < planetList.Count && planetList[index] != null)
            transform.position = planetList[index].transform.position + offset;
        
        if(onShip)
            transform.position = ship.transform.position + offset;
    }
    public void SetPlanetsList(Planet [] planets, int tamList)
    {
        for (int i = 0; i < tamList; i++)
        {
            planetList.Add(planets[i].gameObject);
        }
    }
}
