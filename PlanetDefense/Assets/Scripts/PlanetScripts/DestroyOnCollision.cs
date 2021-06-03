using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour {
    // Start is called before the first frame update

    private PlanetCentral Resc;

   
    void OnCollisionEnter2D (Collision2D collision) {
        Resc = GameObject.Find("Planet").GetComponent<PlanetCentral> ();
        if(collision.gameObject.tag == "Comet")
        {
            Destroy (collision.gameObject);
        }

        if(this.gameObject.tag == "Upgrade1")
        {
            Resc.resources ++;
        }
        
    }
}