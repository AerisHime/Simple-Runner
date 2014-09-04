using UnityEngine;
using System.Collections;

public class GenerateScores : MonoBehaviour {

    isAlive isalive;
    //assign the star prefab in the inspector
    public GameObject stars;

    //balancing values for random generation position
    public float minSpawnY = -0.9f;
    public float maxSpawnY = 3.6f;
    Vector3 startPosition;
    // Use this for initialization
    void Start()

    {
        isalive = gameObject.GetComponent<isAlive>();
        //repeatedly generate obstacles
        InvokeRepeating("CreateStars", 1f, 6f);

    }
    //create the Obstacles at a random position
    void CreateStars()
    {
        float randomY = Random.Range(minSpawnY, maxSpawnY);
        //positioning Vector
        startPosition = new Vector3(18f, randomY, 0);
        Instantiate(stars, startPosition, Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
        if (!isalive.alive)
        {
            CancelInvoke("CreateStars");
        }

    }
}
