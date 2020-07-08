using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class gerarObjetos
{
    public GameObject prefab;
    public int contador;
    public float iniciarTempo;
    public float instaciarEsperar;
    public float tempo;
}

public class Instaciador : MonoBehaviour
{
    public gerarObjetos Objetos;
    public Vector2 instaciarValores;

    // Start is called before the first frame update
    void Start()
    {

        instaciarValores = CameraPrincipal.CoodernadaCamera();
        StartCoroutine(InstanciarObjetos());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator InstanciarObjetos()
    {

        yield return new WaitForSeconds(Objetos.iniciarTempo);
        while (true)
        {
            for (int i = 0; i < Objetos.contador; i++)
            {
                Vector2 posicao = new Vector2(Random.Range(-instaciarValores.x, instaciarValores.x), instaciarValores.y);
                Instantiate(Objetos.prefab, posicao, Quaternion.identity);
                yield return new WaitForSeconds(Objetos.instaciarEsperar);

            }
            yield return new WaitForSeconds(Objetos.tempo);
        }
    }
}
