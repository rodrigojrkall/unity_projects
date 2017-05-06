using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour {

    public int score = 0;
    Text txt;

	void Start () {
        txt = GetComponent<Text>();
	}

	void Update () {
        printScore();
	}

    public void addToScoreVOID()
    {
        score++;
        printScore();
    }

    void printScore()
    {
        txt.text = score.ToString();
    }
}
