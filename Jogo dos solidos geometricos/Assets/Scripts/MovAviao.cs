using System.Net.NetworkInformation;
using System.Net.Mime;
using System;
using System.Threading;
using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovAviao : MonoBehaviour
{

    public GameObject objetos;
    public int escore;

    public float vel = 2.5f;
    

    private float eixoXMin, eixoXMax;
    private float eixoYMin, eixoYMax;

    private float posicaoX, posicaoY;

    [SerializeField]
    private GameObject instanciarBombas;

    [SerializeField]
    private GameObject prefabBomba;


        

    // Start is called before the first frame update
    void Start()
    {
        eixoXMax = CameraPrincipal.LimitarDireitaX(transform.position);
        eixoXMin = CameraPrincipal.LimitarDireitaX(transform.position);
        eixoYMax = CameraPrincipal.LimitarParacimaY(transform.position);
        eixoYMin = CameraPrincipal.LimitarParaBaixoY(transform.position);

        carregarCena();

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-vel * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, vel * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -vel * Time.deltaTime));
        }



        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -0.5f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 0.5f;
        }
        transform.localScale = characterScale;

        var distanceZ = (transform.position - Camera.main.transform.position).z;

        var lefBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).x;
        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceZ)).x;
        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).y;
        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distanceZ)).y;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, lefBorder, rightBorder),
            Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
            transform.position.z);

        escore = objetos.GetComponent<Objetos>().valorLosango;

    }

    private void carregarCena()
    {
        if (escore == 100)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void FixedUpdate()

    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabBomba, instanciarBombas.transform.position, prefabBomba.transform.rotation);
            GetComponent<AudioSource>().Play();
        }
    }



    void OnTriggerEnter2D(Collider2D outro)
    {

        if (outro.tag == "losango")
        {
            Mensagens.pontos += escore;
            Destroy(outro.gameObject);
        }

        if (outro.tag != "losango")
        {
            Mensagens.pontos -= escore;
        }
    }

}

