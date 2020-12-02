using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private bool pressedSpace = true;
    private float xSpeed = 0.5f, zSpeed = 0.5f;
    public Transform explosion;
    private int change = -1;
    private Vector3 impulse = new Vector3(40.0f, 0.0f, 40.0f);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.Space) && !pressedSpace)
          {
            pressedSpace = true;
            print("space");
         }
          else if (!Input.GetKey(KeyCode.Space))
            pressedSpace = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        print("hola");
        zSpeed *= (-1);
    }

}