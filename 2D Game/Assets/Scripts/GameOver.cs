using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text pontosNumero;
    public Text recordeNumero;

	// Use this for initialization
	void Start () {
        pontosNumero.text = PlayerPrefs.GetInt("pontuacao").ToString();
        recordeNumero.text = PlayerPrefs.GetInt("recorde").ToString();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
