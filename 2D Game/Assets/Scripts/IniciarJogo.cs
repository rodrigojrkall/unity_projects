using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IniciarJogo : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        ControleJogador.pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("scene1");
        }
    }
}
