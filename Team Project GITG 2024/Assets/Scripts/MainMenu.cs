using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    public GameObject canvas;
    public Button playb;
    public GameObject title;
    public GameObject diedtitle;
    public GameObject playbutton;
    public Button quitb;
    public Button restb;
    public GameObject restbutton;
    public Camera pcam;
    public Camera main;
    public GameObject player;
    public bool playingNow;
    public Win win;
    public OnDeath dead;
    GameObject winarea;
    public FirstPersonController fpc;
    // Called when we click the "Play" button.
    private void Start()
    {
        main.enabled = true;
        player.SetActive(false);
        playingNow = false;
        playbutton.SetActive(true);
        restbutton.SetActive(false);
        diedtitle.SetActive(false);

        //i belive the player camera is the reasom stuff dont work
       
    }

    void FixedUpdate()
    {
        if(win.win)
        {
            playingNow = false;
        }

        else if(dead.oopsdead)
        {
            player.SetActive(false);
            main.enabled = true;
            playingNow = false;
            canvas.SetActive(true);
            diedtitle.SetActive(true);
            title.SetActive(false);
            playbutton.SetActive(false);
            restbutton.SetActive(true);
            fpc.FPCOFF();
        }
    }

    public void OnPlayButton()
    {
        Cursor.lockState = CursorLockMode.Locked;
        player.SetActive(true);
        canvas.SetActive(false);
        main.enabled = false;
        pcam.enabled = true;
        playingNow = true;

    }

    public void OnQuitButton()
    {

        Application.Quit();

    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }

}