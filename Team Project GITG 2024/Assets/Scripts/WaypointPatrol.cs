using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.XR.Haptics;
public class WaypointPatrol : MonoBehaviour
{

    public NavMeshAgent navAgent;
    public Transform player;
    bool onSight;
    int currentWaypointNum;
    bool playerInRange;
    WaypointPatrol prefabScript;
    GameObject playerStore;
    public MainMenu MainM;
    public float wandRange;
    GameObject MenuStore;
    
    private void Start()
    {
        MenuStore = GameObject.Find("menus");
        MainM = MenuStore.GetComponentInParent<MainMenu>();
        playerStore = GameObject.Find("Player");
        player = playerStore.transform;
        wandRange = 20;
    }

    void FixedUpdate()
    {
        if (MainM.playingNow) {
            if (playerInRange)
            {
                navAgent.SetDestination(player.position);
            }
            else
            {
                if (navAgent.remainingDistance <= navAgent.stoppingDistance)
                {
                    WanderRandomly();
                }
            }

            /*if (navAgent.remainingDistance <= navAgent.stoppingDistance)
            {
                currentWaypointNum = (currentWaypointNum + 1) % waypoints.Length;
                navAgent.SetDestination(waypoints[currentWaypointNum].position);
            }*/



        }
        // Update is called once per frame

        void WanderRandomly()
        {
            Vector3 wanderPoint = transform.position;
            wanderPoint.x += UnityEngine.Random.Range(-wandRange, wandRange);
            wanderPoint.z += UnityEngine.Random.Range(-wandRange, wandRange);
            navAgent.SetDestination(wanderPoint);

            /*
            for (int i = 0; i<3; i++)
            {
                waypoints[i] = new GameObject();
                waypoints[i].position = transform.position;
                waypoints[i].position.x += UnityEngine.Random.Range(-3,3);
                waypoints[i].position.z += UnityEngine.Random.Range(-3, 3);
            }
            */
        }
    }
    public void CatchTheseHands()
    {
        playerInRange = true;
    }
}
