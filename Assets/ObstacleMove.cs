using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 0.2f));


    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag != "Player")
        {
            

        }
    }
}
