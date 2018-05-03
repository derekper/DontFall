using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    //creates entry fields inside inspector
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;

    private void OnTriggerEnter(Collider other)
    {   //resets players position to respawn point
        player.transform.position = respawnpoint.transform.position;
    }

}
