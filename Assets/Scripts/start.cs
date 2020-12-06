using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{

    public AudioClip buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        //AudioManager.instance.Stop("game");
        //AudioManager.instance.Play("mainMenu");

    }

    public void CarregaEscena(string nom)
    {
        SceneManager.LoadScene(nom);
        Time.timeScale = 1;
    }

    public void Button()
    {
        AudioSource.PlayClipAtPoint(buttonSound, new Vector3(0.0f, 0.0f, -10.0f));
    }

}
