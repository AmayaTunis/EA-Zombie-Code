using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveIncrease : MonoBehaviour
{

    public float range;
    public Transform spawnPoint;
    public GameObject zombiePrefab;
    GameObject zombieInstance;
    Vector3 zombCoords;
    public MainMenu MainM;
    int turnOn;
    GameObject Menu;
    
    private void Start()
    {
        Menu = GameObject.Find("menus");
        turnOn = 0;
        range = 13;
    }

    private void Update()
    {
        
        
        if(MainM.playingNow)
        {
            turnOn = turnOn + 1;            
            if(turnOn == 1)
            {
                InvokeRepeating("Spawn", 2.0f, 3.0f);
            }
        }
        else if(!MainM.playingNow)
        {
            CancelInvoke("Spawn");
        }


    }



    void Spawn()
    {
        zombCoords = new Vector3(spawnPoint.position.x + Random.Range(-range, range), 0f, spawnPoint.position.z + Random.Range(-range, range));
        zombieInstance = Instantiate(zombiePrefab, zombCoords, Quaternion.identity);
        
    }
    
    
   
}
