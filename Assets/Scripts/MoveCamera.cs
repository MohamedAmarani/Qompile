using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ball.transform.position.x >=200)
            if(transform.position.x <= 250)
                transform.Translate(1, 0, -0.8f);

        if (ball.transform.position.x < 150)
            if (transform.position.x != 92)
                transform.Translate(-1, 0, 0.8f);

        if (ball.transform.position.z < -100 && ball.transform.position.x < 300 && ball.transform.position.x > 200)
            if (transform.position.y > 133 || transform.position.z > -156)
                transform.Translate(0, -1, 0.7f);
    }
}
