using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionarObjetos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(x: 0, y: 0, z: 1));
    }
}
