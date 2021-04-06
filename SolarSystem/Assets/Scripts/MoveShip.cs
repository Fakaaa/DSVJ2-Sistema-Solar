using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    [SerializeField] float shipSpeed;
    [SerializeField] float rotSpeed;
    private Rigidbody spaceShip;
    private Vector3 movementVec;
    private float angle;
    private int xAngle = 90;

    private void Start()
    {
        spaceShip = gameObject.GetComponent<Rigidbody>();
        movementVec = Vector3.zero;
        angle = transform.rotation.z;
    }
    // Update is called once per frame
    void Update()
    {
        movementVec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.Q))
        {
            angle += Time.deltaTime * rotSpeed;
            transform.rotation = Quaternion.Euler(new Vector3(xAngle, transform.rotation.y, angle));
        }
        if (Input.GetKey(KeyCode.E))
        {
            angle -= Time.deltaTime * rotSpeed;
            transform.rotation = Quaternion.Euler(new Vector3(xAngle, transform.rotation.y, angle));
        }
    }
    void FixedUpdate()
    {
        spaceShip.AddForce((movementVec * shipSpeed) * Time.deltaTime);
    }
}
