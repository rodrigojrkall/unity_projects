using UnityEngine;
using System.Collections;

public class MoverObjeto : MonoBehaviour
{

    public float velocidade;
    private float eixoX;

    public GameObject jogador;
    private bool pontuado;

    // Use this for initialization
    void Start()
    {
        jogador = GameObject.Find("Jogador") as GameObject;
        pontuado = false;
    }

    // Update is called once per frame
    void Update()
    {
        eixoX = transform.position.x;
        eixoX += velocidade * Time.deltaTime;

        transform.position = new Vector3(eixoX, transform.position.y, transform.position.z);

        if (eixoX <= -2.5f)
        {            
            Destroy(transform.gameObject);
        }

        if (eixoX < jogador.transform.position.x && !pontuado)
        {
            pontuado = true;
            ControleJogador.pontuacao += 10;
        }
    }
}
