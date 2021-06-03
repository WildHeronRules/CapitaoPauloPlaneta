using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetCentral : MonoBehaviour {

    public GameObject GameOverPanel;
    public GameObject LifePanel;
    public float resources;
    public int life = 10;

    public Text lifesUI;
    public Text resourcesUI;
    

    // Start is called before the first frame update
    void Start () {
        LifePanel.SetActive(true);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update () {

        if(life < 1){
            GameOverPanel.SetActive(true);
            LifePanel.SetActive(false);
            Time.timeScale = 0;
        }

        lifesUI.text = "Lifes: " + life;
        resourcesUI.text = "Resources: " + resources;
    }

    void OnCollisionEnter2D (Collision2D collision) {

    if (collision.gameObject.tag == "Comet") {
                life -= 1;
            }
    }
}