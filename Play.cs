using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {
    

    public void AllSystemsAreGo()
    {
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(1);
        
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void GoBack()
    {
        SceneManager.UnloadSceneAsync(2);
        SceneManager.LoadScene(0);
    }
}
