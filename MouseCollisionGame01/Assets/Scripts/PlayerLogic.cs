using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour
{

    public float playerSpeed = 2000.0f;

    ScoreLogic addToScore;

    void Start()
    {
        hideMouseCursor();
    }

    void Update()
    {
        movePlayerToMousePosition();
    }

    void movePlayerToMousePosition()
    {
        var mousePosition = Input.mousePosition;

        mousePosition.z = transform.position.z - Camera.main.transform.position.z;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector3.MoveTowards(transform.position, mousePosition, playerSpeed * Time.deltaTime);
    }

    void hideMouseCursor()
    {
        Cursor.visible = false;
    }

    void OnCollisionEnter2D(Collision2D tempCollision)
    {
        if (tempCollision.transform.tag == "Collectable")
        {
            callAddToScoreScript();

            Destroy(tempCollision.gameObject);
        }

        if (tempCollision.transform.tag == "BadCollectable")
        {
            resetGame();

            Destroy(tempCollision.gameObject);
        }
    }

    void callAddToScoreScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>();
        addToScore.addToScoreVOID();
    }

    void resetGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
