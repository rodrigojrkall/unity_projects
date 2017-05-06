using UnityEngine;
using System.Collections;

public class AddObjeto : MonoBehaviour
{

    public GameObject obstaculo;
    public float intervalo;
    private float tempoAtual;
    public float posicaoA;
    public float posicaoB;
    public int posicao;
    public float eixoY;

    // Use this for initialization
    void Start()
    {
        tempoAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtual += Time.deltaTime;

        if (tempoAtual >= intervalo)
        {
            tempoAtual = 0;
            posicao = Random.Range(1, 100);

            if (posicao > 50)
            {
                eixoY = posicaoA;
            }
            else
            {
                eixoY = posicaoB;
            }

            GameObject temporario = Instantiate(obstaculo) as GameObject;
            temporario.transform.position = new Vector3(transform.position.x, eixoY, temporario.transform.position.z);

        }
    }
}
