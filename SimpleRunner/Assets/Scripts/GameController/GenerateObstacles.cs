using UnityEngine;
using System.Collections;

public class GenerateObstacles : MonoBehaviour {

    isAlive isalive;

    //assign the obstacle prefab in the inspector
    public GameObject obstacle;
    
    //balancing values for random generation position
    public float minSpawnY = -0.9f;
    public float maxSpawnY =  3.6f;
    Vector3 startPosition;
	// Use this for initialization
	void Start () {
         //repeatedly generate obstacles
        isalive = gameObject.GetComponent<isAlive>();
        InvokeRepeating("CreateObstacle", 1f, 3f);
     	    
	}
    //create the Obstacles at a random position
    void CreateObstacle()
    {
        float randomY = Random.Range(minSpawnY, maxSpawnY);
        //positioning Vector
        startPosition = new Vector3(12f, randomY, 0);
        Instantiate(obstacle, startPosition, Quaternion.identity);


    }
	
	// Update is called once per frame
	void Update () {
        if (!isalive.alive)
        {
            CancelInvoke("CreateObstacle");
        }
	
	}
}
