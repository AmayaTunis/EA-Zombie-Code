using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public GameObject canvas;
    public Button restb;
    public Button quitb;




    public void RestartButtonClicked()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);
    }

    public void QuitButtonClicked()
    {
        Application.Quit();
    }
    
}