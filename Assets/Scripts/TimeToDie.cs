﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDie : MonoBehaviour
{

    public float timeToDie = 200000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToDie -= Time.deltaTime;
        if (timeToDie <= 0.0f)
            Destroy(gameObject);
    }
}
