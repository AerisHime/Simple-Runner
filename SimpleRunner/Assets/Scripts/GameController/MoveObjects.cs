using UnityEngine;
using System.Collections;

public class MoveObjects : MonoBehaviour {

    //determine speed
    public float speed = 4f;
    GameObject gameController;
    isAlive isalive;
    

	// Use this for initialization
	void Start () {
        gameController = GameObject.Find("GameController");
        isalive = gameController.GetComponent<isAlive>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isalive.alive)
        {
            float currentX = this.transform.position.x;

            //go only in the left direction
            Vector3 direction = Vector3.left;

            //move to the direction determined, at the defined speed.
            this.transform.position += direction * speed * Time.deltaTime;

            if (currentX <= -10)
            {
                Destroy(this.gameObject);
            }
        }
        
	
	}
}
