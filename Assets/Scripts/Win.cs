using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject flag= GameObject.Find("end");
        if (flag == false)
        {
            Destroy(flag);
            Invoke("CarregaEscena", 1f);
        }
            
    }

    public void CarregaEscena()
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }
}
