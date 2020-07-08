using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{

    

    //private float timeDestroy;

    
    private float vel = 10;

    public float Vel
    {   
        get { return vel; }
        set { vel = value; }
    }

    void Mover()
    {
        Vector3 aux = transform.position;
        aux.x += vel * Time.deltaTime;
        transform.position = aux;
    }

    // Start is called before the first frame update
    void Start()
    {
        //timeDestroy = 5.0f;
        //Destroy(gameObject, timeDestroy);
        
    }

    private void Update()
    {
        Mover();
        //transform.Translate(Vector2.right * vel * Time.deltaTime);
    }


}
