using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovimentLogic : MonoBehaviour {

    ScoreLogic addToScore;

	void Start () {
		
	}

	void Update () {
        moveEnemyToPlayer();
	}

    void moveEnemyToPlayer()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(0, 0, 0),1.0f * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if(transformCollision.gameObject.tag == "Projectile")
        {
            callAddToScoreLogic();
            Destroy(transform.gameObject);
        }
    }

    void callAddToScoreLogic()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        addToScore.addToScoreVOID();
    }
}
