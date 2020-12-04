using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Audio Source");
        if (player)
            Destroy(player);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
