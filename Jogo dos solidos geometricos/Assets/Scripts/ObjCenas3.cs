using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjCenas3 : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb2d;
    [SerializeField]
    private float velocidade;
    [SerializeField]
    public int tempoVida;
    [SerializeField]
    private GameObject prefabExplosao;
    [SerializeField]
    private int PontosObjeto;


    // Start is called before the first frame update
    void Start()
    {
        Movimentar();
    }

    void Movimentar()
    {

        rb2d.velocity = -transform.up * velocidade;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomba")
        {
            Instantiate(prefabExplosao, transform.position, transform.rotation);
            MsgCena3.Pontos += PontosObjeto;
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D outro)
    {
        if (outro.tag == "Bomba")
        {
            Destroy(outro.gameObject);
        }

    }
}
