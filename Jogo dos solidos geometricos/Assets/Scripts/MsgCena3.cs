using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MsgCena3 : MonoBehaviour
{
    public Text txtPontos;
    public static int Pontos;


    // Start is called before the first frame update
    void Start()
    {
        Pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {

        txtPontos.text = "Pontos:  " + Pontos;
        
    }
 
}