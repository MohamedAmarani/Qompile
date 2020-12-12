using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera3 : MonoBehaviour
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
        if (ball.transform.position.z > -17.6f && ball.transform.position.x < 93)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(46.6f, 57.3f, 5.7f), step);
        }

        if (ball.transform.position.z < -17.6f && ball.transform.position.z > -68 && ball.transform.position.x < 93)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(54.5f, 73.1f, -38.7f), step);
        }

        if (ball.transform.position.z < -68 && ball.transform.position.x > 32 && ball.transform.position.x < 214)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(122.8f, 107.2f, -82.9f), step);
        }

        if (ball.transform.position.z > -68 && ball.transform.position.z < 0 && ball.transform.position.x > 100 && ball.transform.position.x < 230)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(165.4f, 80.9f, -34.1f), step);
        }

        if (ball.transform.position.z > 0 && ball.transform.position.x > 94 && ball.transform.position.x < 230)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(142.3f, 70.3f, 30.1f), step);
        }

    }
}
