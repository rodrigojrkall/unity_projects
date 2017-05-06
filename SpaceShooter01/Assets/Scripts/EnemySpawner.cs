using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

	public GameObject enemyToSpawn;
	public bool canSpawn = true;
	public float enemySpanwTime = 1.0f;
	public float maxX = 28.0f;
	public float startingY = 20.0f;
	public float randomX;

	void Start ()
	{
		StartCoroutine (spawnEnemyTimer ());
	}

	void Update ()
	{

	}

	IEnumerator spawnEnemyTimer ()
	{
		while (canSpawn) {
			spanwEnemy ();
			yield return new WaitForSeconds (enemySpanwTime);
		}        
	}

	void spanwEnemy ()
	{
		randomX = Random.Range (-maxX, maxX);
		Instantiate (enemyToSpawn, new Vector3 (randomX, startingY, 0), Quaternion.identity);
	}
}
