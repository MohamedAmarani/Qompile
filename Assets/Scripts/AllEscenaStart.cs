﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class AllEscenaStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //AudioManager.instance.Stop("mainMenu");
       // AudioManager.instance.Play("game");
    }

    public void CarregaEscena(string nom)
    {
        SceneManager.LoadScene(nom);
        Time.timeScale = 1;
    }
}
