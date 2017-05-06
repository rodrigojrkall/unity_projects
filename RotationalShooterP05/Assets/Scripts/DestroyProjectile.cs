using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyProjectile : MonoBehaviour {


	void Start () {
		
	}
	

	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D transformCollision)
    {
        if(transformCollision.gameObject.tag == "Enemy")
        {
            Destroy(transform.gameObject);
        }
    }
}
