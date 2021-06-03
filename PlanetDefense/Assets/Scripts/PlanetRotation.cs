using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {
    public float speed;
    public Vector2 target;

    private Vector3 zAxis = new Vector3 (0, 0, 1);

    void start () {
        target = new Vector2(0.0f, 0.0f);
    }
    void FixedUpdate () {
        target = GameObject.Find("Planet").transform.position;
        transform.RotateAround(target, zAxis, speed);
    }
}