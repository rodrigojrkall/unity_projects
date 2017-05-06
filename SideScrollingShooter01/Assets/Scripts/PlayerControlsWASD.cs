using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsWASD : MonoBehaviour
{
    public float playerSpeed = 1.0f;

    public float maxPlayerY = 7.5f;
    public float maxPlayerX = 19.5f;

    //public float projectileOffSet = 2.0f;

    public GameObject projectile;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
        keyThenSpawnProjectile();
    }

    void playerMovement()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y <= maxPlayerY)
        {
            transform.Translate(0, playerSpeed, 0);
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerX)
        {
            transform.Translate(-playerSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y >= -maxPlayerY)
        {
            transform.Translate(0, -playerSpeed, 0);
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerX)
        {
            transform.Translate(playerSpeed, 0, 0);
        }
    }

    void keyThenSpawnProjectile()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(projectile, new Vector3(transform.position.x + 2, transform.position.y, 0), Quaternion.identity);
        }
    }
}
