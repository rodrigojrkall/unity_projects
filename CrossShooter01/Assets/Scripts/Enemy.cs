using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector2 movementDirection;
    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveEnemy();
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.GetComponent<Bullet>() != null)
        {
            Destroy(this.gameObject);
            Destroy(c.gameObject);
        }

        if (c.gameObject.GetComponent<Player>() != null)
        {
            Destroy(c.gameObject);
        }
    }

    void moveEnemy()
    {
        this.GetComponent<Rigidbody2D>().velocity = movementDirection * speed;
    }
}
