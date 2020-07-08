using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void NewGame() {
        SceneManager.LoadScene("Carregando cena 2", LoadSceneMode.Single);
    }
    
    public void LoadGame(string gameType) {
        Debug.Log("Carregar o jogo do tipo.." + gameType);
    }
}
