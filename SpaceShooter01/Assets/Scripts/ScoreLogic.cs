using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour {

    Text txt;

    public int score = 0;

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

    public void printScore()
    {
        txt.text = "Score: " + score;
    }
}
