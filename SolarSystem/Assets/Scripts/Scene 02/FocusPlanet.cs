using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusPlanet : MonoBehaviour
{
    //---
    [SerializeField] GameObject ship;
    [SerializeField] GameObject shipCamera;
    [SerializeField] GameObject mainCamera;
    [SerializeField] Vector3 offset;
    //---
    public List<GameObject> planetList;
    private int index = 0;
    private Vector3 auxOffset;
    public Vector3 auxPosCam;
    public Quaternion auxRotCam;
    private bool onShip;
    private bool planetSelect;
    //---

    private void Start()
    {
        auxOffset = offset;
        onShip = false;
        planetSelect = true;
        index = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            onShip = false;
            planetSelect = true;
            index = 0;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            onShip = false;
            planetSelect = true;
            index = 1;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            onShip = false;
            planetSelect = true;
            index = 2;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            onShip = false;
            planetSelect = true;
            index = 3;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            onShip = false;
            planetSelect = true;
            index = 4;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            onShip = false;
            planetSelect = true;
            index = 5;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            onShip = false;
            planetSelect = true;
            index = 6;
            offset *= 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            onShip = false;
            planetSelect = true;
            index = 7;
            offset *= 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            onShip = false;
            planetSelect = true;
            index = 8;
            offset = auxOffset;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            onShip = true;
            planetSelect = false;
        }

    }
    void LateUpdate()
    {
        //if (!onShip)
        //{
        //    transform.parent = null;
        //    transform.position = auxPosCam;
        //    transform.rotation = auxRotCam;
        //}
        //else
        //    transform.parent = ship.transform;
        if(onShip && !planetSelect)
        {
            mainCamera.gameObject.SetActive(false);
            shipCamera.gameObject.SetActive(true);
        }
        if (!onShip && planetSelect)
        {
            mainCamera.gameObject.SetActive(true);
            shipCamera.gameObject.SetActive(false);
        }

        if (index < planetList.Count && planetList[index] != null && planetSelect)
            mainCamera.transform.position = planetList[index].transform.position + offset;
    }
    public void SetPlanetsList(Planet [] planets, int tamList)
    {
        for (int i = 0; i < tamList; i++)
        {
            planetList.Add(planets[i].gameObject);
        }
    }
}
