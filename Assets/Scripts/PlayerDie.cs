using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDie : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool encuentra = transform.Find("Ball");
        Debug.Log(encuentra);
        if (encuentra == false)
        {
            Invoke("VolverCarregaEscena", 5f);
        }
    }

    public void VolverCarregaEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
