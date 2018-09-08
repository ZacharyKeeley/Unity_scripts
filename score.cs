using UnityEngine;
// this allows us to use 
using UnityEngine.UI;

public class score : MonoBehaviour {

    // this references the transform object in the player instance
    public Transform player;

    // we create a reference to our text object
    public Text scoreText;
	
	// Update is called once per frame
	void Update () {

        // we assign the player's z position to the text part of the UI
        // we must also convert the float to a string 
        // this is done by using the ToString() method
        scoreText.text = player.position.z.ToString("0");

        // uncomment the next line to initialize debugging of player position
        // Debug.log(player.position.z);
	}
}
