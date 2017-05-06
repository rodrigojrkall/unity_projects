using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour {

    public float projectileSpeed = 1.0f;

	void Start () {
		
	}
	
	void Update () {
        moveProjectileRight();
	}

    void moveProjectileRight()
    {
        transform.Translate(projectileSpeed, 0, 0);
    }
}
