using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pausa : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioClip buttonSound;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
    }
    public void Continual()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
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
