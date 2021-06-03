using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometSpawn : MonoBehaviour
{

    public GameObject Comet;

    public float spawnTime = 2;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addComet", spawnTime, spawnTime);
    }

    // Update is called once per frame
    
    void addComet(){
        
        
        Renderer renderer = GetComponent<Renderer>();
        
        var x1= transform.position.x - renderer.bounds.size.x/2;
        var x2= transform.position.x + renderer.bounds.size.x/2;

        var y1= transform.position.y - renderer.bounds.size.y/2;
        var y2= transform.position.y + renderer.bounds.size.y/2;

        var spawnPoint= new Vector2(Random.Range(x1, x2), Random.Range(y1, y2));

        Instantiate(Comet, spawnPoint, Quaternion.identity);
    }
}
