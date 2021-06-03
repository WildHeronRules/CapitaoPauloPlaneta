using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour {

    public float resources;
    private PlanetCentral Resc;
    // Start is called before the first frame update
    void Start () { 

        Resc = GameObject.Find("Planet").GetComponent<PlanetCentral> ();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown (0)) {
            RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

            if (hit.collider != null) {

                if (hit.collider.gameObject == gameObject) {
                    Destroy (gameObject);
                    Resc.resources ++;
                }
            }
        }

    }
}