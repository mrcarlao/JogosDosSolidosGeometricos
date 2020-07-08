using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;
    [SerializeField]
    private float minimo;
    [SerializeField]
    private float maximo;
    [SerializeField]
    private float velocidade;
    [SerializeField]
    public int valorLosango;
    private int pontuacao;


    // Start is called before the first frame update
    void Start()
    {
        Movimentar();
    }

    void Movimentar()
    {
        rb2d.angularVelocity = Random.Range(minimo, maximo);
        rb2d.velocity = -transform.up * velocidade;
    }

    
}
