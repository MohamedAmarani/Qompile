using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private float speed = 40;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ball.transform.position.z < 43 && ball.transform.position.z > -44 && ball.transform.position.x < 160)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(92, 105, -1), step);
        }

        if (ball.transform.position.z > -32 && ball.transform.position.z < 97 && ball.transform.position.x > 160 && ball.transform.position.x < 358)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(256, 134.94f, 33.7f), step);
        }

        if (ball.transform.position.z < -32 && ball.transform.position.z > -107 && ball.transform.position.x > 160 && ball.transform.position.x < 358)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(251.7f, 93.1f, -70.1f), step);
        }

        if (ball.transform.position.z < -107 && ball.transform.position.x > 160 && ball.transform.position.x < 358)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(251.7f, 116.6f, -162.3f), step);
        }

        if (ball.transform.position.z < 27 && ball.transform.position.z > -39.5f && ball.transform.position.x > 358 && ball.transform.position.x < 486)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(425.5f, 82.9f, -5.4f), step);
        }

        if (ball.transform.position.z < -39.5f && ball.transform.position.x > 406 && ball.transform.position.x < 545)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(472.6f, 121.45f, -58.8f), step);
        }

        if (ball.transform.position.z > -39.5f && ball.transform.position.z < 81 && ball.transform.position.x > 509 && ball.transform.position.x < 545)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(521.6f, 127.9f, 22.3f), step);
        }

        if (ball.transform.position.z > 81 && ball.transform.position.z < 172 && ball.transform.position.x > 509 && ball.transform.position.x < 545)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(521.6f, 101.2f, 127.2f), step);
        }

        if (ball.transform.position.z > 172 && ball.transform.position.x > 358 && ball.transform.position.x < 545)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(446.9f, 169.2f, 252), step);
        }

    }
}
