﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScrolCena : MonoBehaviour
{
    public RawImage back, front, fly; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        back.uvRect = new Rect(0.01f * Time.time,0,1,1);
        front.uvRect = new Rect(0.03f * Time.time,0,1,1);
        fly.uvRect = new Rect(0.1f * Time.time, 0, 1, 1);
    }
}
