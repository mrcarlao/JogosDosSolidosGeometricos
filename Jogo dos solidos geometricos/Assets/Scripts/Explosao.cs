using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosao : MonoBehaviour
{
    [SerializeField]
    private float tempo;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tempo);

        if (GetComponent<AudioSource>() != null)
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, tempo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
