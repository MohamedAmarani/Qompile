using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera1 : MonoBehaviour
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
        if (ball.transform.position.x < 194 && ball.transform.position.z > -58)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(75.8f, 136.6f, -30.3f), step);
        }

        if (ball.transform.position.z < -83.4 && ball.transform.position.x < 194 && ball.transform.position.z > -137)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(75.8f, 136.6f, -81.5f), step);
        }
        
        if (ball.transform.position.z < -137 && ball.transform.position.x < 170 && ball.transform.position.z > -230)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(71.4f, 111, -183.5f), step);
        }

        if (ball.transform.position.z < -230.1f)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(206.2f, 133.8f, -268.9f), step);
        }

        if (ball.transform.position.x < 319 && ball.transform.position.x > 245 && ball.transform.position.z > -220 && ball.transform.position.z < -140.2)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(285.2f, 104f, -184.4f), step);
        }

        if (ball.transform.position.x < 319 && ball.transform.position.x > 245 && ball.transform.position.z > -140.2)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(325.1f, 136.4f, -146.3f), step);
        }

    }
}
