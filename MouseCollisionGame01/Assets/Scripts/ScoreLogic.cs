using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{

    Text txt;
    int score = 0;

    // Use this for initialization
    void Start()
    {
        txt = transform.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        printScore();
    }

    public void addToScoreVOID()
    {
        score++;
        printScore();
    }

    void printScore()
    {
        txt.text = "Score: " + score;
    }
}
