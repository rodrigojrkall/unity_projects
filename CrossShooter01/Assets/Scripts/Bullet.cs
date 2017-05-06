using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public Vector3 movementDirection;
    public float speed = 8.0f;

    public float lifeTime = 1.0f;

	void Start () {
		
	}
	
	void Update () {
        moveTransform();
        destroyTransformByLifeTime();
    }

    void moveTransform()
    {
        this.GetComponent<Rigidbody2D>().velocity = movementDirection * speed;
    }

    void destroyTransformByLifeTime()
    {
        lifeTime -= Time.deltaTime;

        if(lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
