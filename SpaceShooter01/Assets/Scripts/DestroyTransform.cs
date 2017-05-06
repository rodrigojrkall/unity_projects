using UnityEngine;

public class DestroyTransform : MonoBehaviour
{

	ScoreLogic addToScore;
	public GameObject particle;

	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

	void OnCollisionEnter2D (Collision2D transformCollision)
	{
		if (transformCollision.gameObject.tag == "Collision") {

			spawnParticle (transformCollision.transform.position);

			Destroy (transformCollision.gameObject);

			callAddToScoreLogicScript ();
		}
	}

	void callAddToScoreLogicScript(){
		addToScore = GameObject.FindGameObjectWithTag ("GUI").GetComponent<ScoreLogic> ();
		addToScore.addToScoreVOID ();	
	}

	void spawnParticle (Vector2 tempPosition)
	{
		Instantiate (particle, tempPosition, Quaternion.identity);
	}
}
