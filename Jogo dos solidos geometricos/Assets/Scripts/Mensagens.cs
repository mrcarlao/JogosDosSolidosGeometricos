using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mensagens : MonoBehaviour
{

    
    

    public Text txtPontos;
    public static int pontos;
    

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;    
    }

    // Update is called once per frame
    void Update()
    {
       
        txtPontos.text = "Pontos:  " + pontos;
        carregarCena();
    }

    void carregarCena()
    {
        if( pontos == 100)
        {
            SceneManager.LoadScene(4);
        }
       
    }
}
