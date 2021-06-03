using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUpgrades : MonoBehaviour
{

    public GameObject Upgrade1;
    private float cont = 0;
    private PlanetCentral Resc;

    // Start is called before the first frame update
    void Start()
    {
        Resc = GameObject.Find("Planet").GetComponent<PlanetCentral> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Resc.resources >= 10 && cont == 0){
            SpawnUpgrade1();
            Resc.resources = Resc.resources - 10;
            cont = 1;
        }
    }

    void SpawnUpgrade1(){
        var spawnPoint= new Vector2(-1.598922f, 1.069151f);
        Instantiate(Upgrade1, spawnPoint, Quaternion.identity);
    }
}
