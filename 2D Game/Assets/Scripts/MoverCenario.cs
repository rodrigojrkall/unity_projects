using UnityEngine;
using System.Collections;

public class MoverCenario : MonoBehaviour
{

    private Material materialAtual;
    public float velocidade;
    private float offSet;

    // Use this for initialization
    void Start()
    {
        materialAtual = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offSet += velocidade * Time.deltaTime;

        materialAtual.SetTextureOffset("_MainTex", new Vector2(offSet, 0));
    }
}
