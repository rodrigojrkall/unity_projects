using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{

    public GameObject projectile;

    public float playerSpeed = 0.5f;
    public float shootingSpeed = 0.5f;

    public float maxPlayerDistance = 24.0f;
    public float projectileCollisionOffSet = 4.0f;

    public bool isShooting = true;

    int screenWidth = Screen.width;

    void Start()
    {
        StartCoroutine(projectileShootTimer());
    }

    void Update()
    {
        playerMovement();

    }

    void playerMovement()
    {
        Touch myTouch = Input.GetTouch(0);

        if (myTouch.phase == TouchPhase.Stationary)
        {
            if (Input.touches[0].rawPosition.x > screenWidth / 2 && transform.position.x < maxPlayerDistance)
            {
                transform.Translate(playerSpeed, 0, 0);
            }
            if (Input.touches[0].rawPosition.x < screenWidth / 2 && transform.position.x > -maxPlayerDistance)
            {
                transform.Translate(-playerSpeed, 0, 0);
            }
        }
    }

    IEnumerator projectileShootTimer()
    {
        while (isShooting)
        {
            spawnProjectile();
            yield return new WaitForSeconds(shootingSpeed);
        }
    }

    void spawnProjectile()
    {
        Instantiate(projectile, new Vector3(transform.position.x, transform.position.y + projectileCollisionOffSet, 0), Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if (tempCollision.gameObject.tag == "Collision")
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
