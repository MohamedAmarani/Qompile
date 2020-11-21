using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playAgain : MonoBehaviour
{
    void Start()
    {

    }
    public void CarregaEscena(string nom)
    {
        SceneManager.LoadScene(nom);
        Time.timeScale = 1;
    }
    public void Clicar()
    {

    }
}