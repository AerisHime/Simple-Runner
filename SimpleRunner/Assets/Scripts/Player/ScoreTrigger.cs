using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {

    ScoreSystem scoreSystem;
    public GameObject gameController;

    void Start()
    {
        scoreSystem = gameController.gameObject.GetComponent<ScoreSystem>();
    }
//define behaviour when hitting a score item
    void OnTriggerEnter2D(Collider2D otherObj)
    {
        if (otherObj.gameObject.tag == "Score")
        {

            scoreSystem.AddScore();
            scoreSystem.ShowScore();
            Destroy(otherObj.gameObject);
        }

    }
}
