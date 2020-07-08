﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartCena2 : MonoBehaviour
{
    public Text txtCarregando;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BtnClick()
    {
        StartCoroutine(LoadGameProg());
    }

    IEnumerator LoadGameProg()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(2);

        while (!async.isDone)
        {
            txtCarregando.enabled = true;
            yield return null;
        }
    }
}
