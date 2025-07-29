using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDeath : MonoBehaviour
{
    public Transform player;
    public bool oopsdead;
    public Collider drange;
    public bool drangeentered;
    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (drange != null)
        {
            drangeentered = true;
        }
        if (drangeentered)
        {
            if (collision.transform == player)
            {
                oopsdead = true;
            }
        }
    }

}
