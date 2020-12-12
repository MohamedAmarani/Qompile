using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera4 : MonoBehaviour
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
        if ((ball.transform.position.z < 23 && ball.transform.position.z > -37 && ball.transform.position.x > 11 && ball.transform.position.x < 45.4f)
                || (ball.transform.position.z < 23 && ball.transform.position.z > 0 && ball.transform.position.x > 45.4f && ball.transform.position.x < 75))
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(59.6f, 73.46f, -5.2f), step);
        }

        if (ball.transform.position.z > 23 && ball.transform.position.z < 122 && ball.transform.position.x > 11 && ball.transform.position.x < 129)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(92.1f, 109.2f, 74.1f), step);
        }

        if (ball.transform.position.z > 122 && ball.transform.position.x > 52 && ball.transform.position.x < 186)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(122.5f, 82.8f, 151.6f), step);
        }

        if (ball.transform.position.z > 122 && ball.transform.position.x > 186)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(235.2f, 69.6f, 151f), step);
        }

        if (ball.transform.position.z < -27 && ball.transform.position.x > 47.8f && ball.transform.position.x < 163)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(102.8f, 77.9f, -31.2f), step);
        }

        if (ball.transform.position.z < -5 && ball.transform.position.x > 163 && ball.transform.position.x < 276)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(221, 71.8f, -34.1f), step);
        }

        if (ball.transform.position.z < -5 && ball.transform.position.x > 276)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(332.6f, 75.7f, -36.6f), step);
        }

    }
}
