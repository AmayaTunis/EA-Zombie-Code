using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;


public class Win : MonoBehaviour
{
    public Transform player;
    GameObject playerStore;
    public Transform Tele;
    public bool win;
    GameObject winarea;
    // Start is called before the first frame update
    void Start()
    {
        winarea = GameObject.Find("WinArea");
        winarea.SetActive(false);
        
        playerStore = GameObject.Find("Player");
        player = playerStore.transform;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            winarea.SetActive(true);
            win = true;
            Tele = GameObject.Find("TelePoint").transform;
            player.position = Tele.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
