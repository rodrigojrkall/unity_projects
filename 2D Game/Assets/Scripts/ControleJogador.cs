using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControleJogador : MonoBehaviour
{

    public Animator animador;
    private bool abaixar;

    public Rigidbody2D jogadorRigidbody;
    public int forcaPulo;

    public Transform checarChao;
    private bool pisandochao;
    public LayerMask chao;

    public float tempoAbaixar;
    private float temporario;

    public Transform colisor;

    public AudioSource som;
    public AudioClip somPular;
    public AudioClip somAbaixar;

    public static int pontuacao;

    public Text pontos;

    // Use this for initialization
    void Start()
    {
        pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pontos.text = pontuacao.ToString();

        //Se o botao de pulo for apertado, então faça isso, senão faça aquilo
        if (Input.GetButtonDown("BotaoPular") && pisandochao)
        {
            jogadorRigidbody.AddForce(new Vector2(0, forcaPulo));
            som.PlayOneShot(somPular);
            som.volume = 1f;

            if (abaixar)
            {
                colisor.position = new Vector3(colisor.position.x, colisor.position.y + 0.4f, colisor.position.z);
                abaixar = false;
            }
        }

        if (Input.GetButtonDown("BotaoAbaixar") && pisandochao && !abaixar)
        {
            colisor.position = new Vector3(colisor.position.x, colisor.position.y - 0.4f, colisor.position.z);
            abaixar = true;
            temporario = 0;
            som.PlayOneShot(somAbaixar);
            som.volume = 0.5f;
        }

        pisandochao = Physics2D.OverlapCircle(checarChao.position, 0.3f, chao);

        if (abaixar)
        {
            temporario += Time.deltaTime;
            if (temporario >= tempoAbaixar)
            {
                colisor.position = new Vector3(colisor.position.x, colisor.position.y + 0.4f, colisor.position.z);
                abaixar = false;
            }
        }

        animador.SetBool("pular", !pisandochao);
        animador.SetBool("abaixar", abaixar);
    }

    void OnTriggerEnter2D()
    {
        PlayerPrefs.SetInt("pontuacao", pontuacao);

        if (pontuacao > PlayerPrefs.GetInt("recorde"))
        {
            PlayerPrefs.SetInt("recorde", pontuacao);
        }

        SceneManager.LoadScene("gameOver");
    }
}
