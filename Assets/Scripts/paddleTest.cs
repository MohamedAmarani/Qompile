using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleTest : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Rigidbody rb;
    public float distance = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        float dist = target.position.x - transform.position.x;
        //Debug.Log("La DISTANCIA es" + Mathf.Abs(dist));
        if (Mathf.Abs(dist) < distance)
        {
            direction.y = direction.x = 0;
            rb.velocity = direction.normalized * speed;
        }

    }
}
