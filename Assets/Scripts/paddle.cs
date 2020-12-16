using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
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
        Debug.Log("La direccion es" + direction.x);

        if (Mathf.Abs(direction.x) < distance)
        {
            direction.x = direction.y = 0;
            rb.velocity = direction.normalized * speed;
        }

    }

}
