using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateInvaders : MonoBehaviour
{
    public GameObject invader;

    // Start is called before the first frame update
    void Start()
    {
        for (int j = 0; j < 5; j++)
            for (int i = 0; i < 10; i++)
            {
                GameObject obj = (GameObject)Instantiate(invader, new Vector3(i - 4.5f, 0.75f * j + 1.2f, 0.0f), transform.rotation);
                obj.transform.parent = transform;
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
