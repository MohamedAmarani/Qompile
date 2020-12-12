using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera2 : MonoBehaviour
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
        if (ball.transform.position.x < 130 && ball.transform.position.x > 12 && ball.transform.position.z > -36)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(69.7f, 86.8f, 2.5f), step);
        }

        if (ball.transform.position.z < -36 && ball.transform.position.x < 216 && ball.transform.position.x > 94)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(152.2f, 76.2f, -66.9f), step);
        }

        if (ball.transform.position.z > -36 && ball.transform.position.x < 275 && ball.transform.position.x > 150)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(213.1f, 82.7f, -3.4f), step);
        }

        if (ball.transform.position.z < -40 && ball.transform.position.x < 275 && ball.transform.position.x > 230)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(249f, 109.4f, -87.6f), step);
        }

    }
}
