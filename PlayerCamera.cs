using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {

        // prints the position of the player to the console
        // Debug.Log(player.position);
        // sets the position of the camera to the position of the player
        // also creates a first person POV
        transform.position = player.position + offset;
	}
}
