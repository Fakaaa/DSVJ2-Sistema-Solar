using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    [SerializeField] float shipSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0,0, (shipSpeed*0.5f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, (shipSpeed * 0.5f) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3((shipSpeed * 0.5f) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3((shipSpeed * 0.5f) * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, 0, shipSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -shipSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(-shipSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(shipSpeed * Time.deltaTime, 0, 0);
        }
    }
}
