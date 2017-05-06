using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementLogic : MonoBehaviour
{

    public float enemySpeed = 0.6f;

    void Start()
    {

    }

    void Update()
    {
        moveEnemyLeft();
    }

    void moveEnemyLeft()
    {
        transform.Translate(-enemySpeed, 0, 0);
    }


}
