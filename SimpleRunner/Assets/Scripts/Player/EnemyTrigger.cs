using UnityEngine;
using System.Collections;

public class EnemyTrigger : MonoBehaviour {


    ScoreSystem scoreSystem;
    public GameObject gameController;
    isAlive isalive;
    int triggerHash;
    Animator playerAnim;

    void Start()
    {
        scoreSystem = gameController.gameObject.GetComponent<ScoreSystem>();
        isalive = gameController.gameObject.GetComponent<isAlive>();
        playerAnim = this.gameObject.GetComponent<Animator>();
        triggerHash = Animator.StringToHash("deathTrigger");
    }

    void OnCollisionEnter2D(Collision2D otherObj)
    {
        if (otherObj.gameObject.tag == "Death")
        {
            //collision behaviour. for now: reload the level
            scoreSystem.SaveScore();
            scoreSystem.CalcHighScore();
            isalive.alive = false;
            playerAnim.SetTrigger(triggerHash);
            Destroy(otherObj.gameObject);
            //Application.LoadLevel(0);
        }
    }


}
