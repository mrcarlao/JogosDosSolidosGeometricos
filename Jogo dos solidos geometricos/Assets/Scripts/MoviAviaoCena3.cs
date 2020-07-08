using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviAviaoCena3 : MonoBehaviour
{


    //public GameObject objetos;
    public int escore;

    private float eixoXMin, eixoXMax;
    private float eixoYMin, eixoYMax;

    public float vel = 2.5f;

    [SerializeField]
    private GameObject instanciarBombas;

    [SerializeField]
    private GameObject prefabBomba;

    public bool face = true;
    public Transform aviao;

    private float controle;
    public float tempodabala;

    // Start is called before the first frame update
    void Start()
    {


        aviao = GetComponent<Transform>();

        eixoXMax = CameraPrincipal.LimitarDireitaX(transform.position);
        eixoXMin = CameraPrincipal.LimitarDireitaX(transform.position);
        eixoYMax = CameraPrincipal.LimitarParacimaY(transform.position);
        eixoYMin = CameraPrincipal.LimitarParaBaixoY(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && !face)
        {
            Flip();
        }

        else if (Input.GetKey(KeyCode.LeftArrow) && face)
        {
            Flip();
        }

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


        var distanceZ = (transform.position - Camera.main.transform.position).z;

        var lefBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).x;
        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distanceZ)).x;
        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distanceZ)).y;
        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, distanceZ)).y;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, lefBorder, rightBorder),
            Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
            transform.position.z);

        //escore = objetos.GetComponent<Objetos>().valorLosango;

    }

    void Flip()
    {
        face = !face;
        Vector3 scala = aviao.localScale;
        scala.x *= -1;
        aviao.localScale = scala;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time > controle)
            {
                controle = Time.time + tempodabala;
                GameObject bombaInst = Instantiate(prefabBomba, instanciarBombas.transform.position, Quaternion.identity) as GameObject;
                bombaInst.GetComponent<Bomba>().Vel *= transform.localScale.x;
            }

            GetComponent<AudioSource>().Play();
        }
    }


}