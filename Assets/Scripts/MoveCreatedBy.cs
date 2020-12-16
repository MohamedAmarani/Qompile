using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCreatedBy : MonoBehaviour
{
    // Start is called before the first frame update
    private bool change = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localEulerAngles.x < 45.0f && !change)
        {
            transform.Rotate(new Vector3(0.5f, 0, 0));
            if (transform.localEulerAngles.x > 40.0f)
                change = true;

        }
        else
        {

            transform.Rotate(new Vector3(-0.5f, 0, 0));

        }

    }
}
