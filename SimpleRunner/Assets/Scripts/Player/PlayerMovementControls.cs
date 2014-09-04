using UnityEngine;
using System.Collections;

public class PlayerMovementControls : MonoBehaviour {

    //variable for jump height of player, can be changed in Inspector
    public Vector2 jumpHeight = new Vector2(0, 5);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //jump when left mouse button is clicked / screen is touched
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = jumpHeight;
        }
	
	}
}
