using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyAndProjectile : MonoBehaviour {

    public GameObject orangeExplosion;
    public GameObject whiteExplosion;

    public float maxTransformPosition = 30.0f;

    ScoreLogic addToScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        destroyWhenOutOfScreen();
    }

    void callScoreLogicScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        addToScore.addToScoreVOID();
    }

    void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if(tempCollision.gameObject.tag == "Collision")
        {
            spawnParticle(tempCollision.transform.position);
            callScoreLogicScript();
            Destroy(tempCollision.gameObject);
        }

        if (tempCollision.gameObject.tag == "Projectile")
        {
            spawnParticle(tempCollision.transform.position);
            Destroy(tempCollision.gameObject);
        }
    }

    void spawnParticle(Vector2 tempPosition)
    {
        Instantiate(orangeExplosion, tempPosition, Quaternion.identity);
        Instantiate(whiteExplosion, tempPosition, Quaternion.identity);
    }

    void destroyWhenOutOfScreen()
    {
        if(transform.position.x > maxTransformPosition || transform.position.x < -maxTransformPosition)
        {
            Destroy(transform.gameObject);
        }
    }
}
