using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleH : MonoBehaviour
{
    public float speed;
    public Transform target;
    public Rigidbody rb;
    //public float distance = 30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        rb.velocity = direction.normalized * speed;

    }
}
