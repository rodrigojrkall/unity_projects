using System.Collections;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour {


	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if (transformCollision.gameObject.tag == "Projectile")
        {
            Destroy(transformCollision.gameObject);
        }
    }
}
