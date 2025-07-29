using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Observe : MonoBehaviour
{
    public Transform player;
    public bool playerInRange;
    bool onSight;
    public WaypointPatrol waypointPatrol;
    GameObject playerStore;
    

    private void Start()
    {
        playerStore = GameObject.Find("Player");
        player = playerStore.transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            playerInRange = true;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {

            playerInRange = false;
        }
        
    }

    void FixedUpdate()
    {
        if (playerInRange)
        {

            Vector3 direction = player.position - transform.position;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == player)
                {
                    Spotted();
                }
            }
        }
        
    }

    public void Spotted()
    {
        waypointPatrol.CatchTheseHands();

    }

    
   
    
}
