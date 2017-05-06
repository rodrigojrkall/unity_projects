using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectiles : MonoBehaviour
{

    public GameObject projectile;
    public Vector3 playerOffSet = new Vector3(0,0,0);

    void Start()
    {

    }

    void Update()
    {
        getMouseClickDown();
    }

    void getMouseClickDown()
    {
        if (Input.GetMouseButtonDown(button: 0))
        {
            spawnTheProjectileVOID();
        }
    }

    void spawnTheProjectileVOID()
    {
        GameObject projectileClone;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        projectileClone = Instantiate(projectile, transform.TransformPoint(Vector3.left + playerOffSet), Quaternion.Euler(0, 0, transform.eulerAngles.z)) as GameObject;

        Rigidbody2D projectileRigidBody = projectileClone.AddComponent<Rigidbody2D>();
        projectileRigidBody.velocity = mousePosition * 4.0f;
        projectileRigidBody.gravityScale = 0;

    }
}
