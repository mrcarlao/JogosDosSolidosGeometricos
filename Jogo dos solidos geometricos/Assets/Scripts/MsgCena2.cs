using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MsgCena2 : MonoBehaviour
{




    public Text txtPontos;
    public static int pontos2;


    // Start is called before the first frame update
    void Start()
    {
        pontos2 = 0;
    }

    // Update is called once per frame
    void Update()
    {

        txtPontos.text = "Pontos:  " + pontos2;
        carregarCena();
    }

    void carregarCena()
    {
        
        if (pontos2 == 100)
        {
            SceneManager.LoadScene(5);
        }
    }
}