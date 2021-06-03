using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometMove : MonoBehaviour
{
    // Start is called before the first frame update


    public Vector2 planet;
    public float speed;
    
    
    void Start()
    {
       planet = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        planet = GameObject.Find("Planet").transform.position;
        transform.position = Vector2.MoveTowards(transform.position, planet, speed * Time.deltaTime);
        transform.Rotate (Vector3.forward);
    }


}
