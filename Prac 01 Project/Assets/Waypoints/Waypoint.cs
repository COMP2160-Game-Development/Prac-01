using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    private PlayerMovement player;
    
    void Start()
    {
        player = GameObject.FindObjectOfType<PlayerMovement>();
    }

    void OnMouseDown()
    {
        player.Target = transform.position;
    }
}
