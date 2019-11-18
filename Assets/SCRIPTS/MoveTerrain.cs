using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveTerrain : MonoBehaviour {
    private float speed = 10;
    float size = 20;

    // Update is called once per frame
    void Update () {
        transform.Translate (0, 0, speed);

        if(this.transform.position.z + size < 0) {
            Debug.Log("out of Display");
            this.transform.Translate(0, 0, size * 2);
        }
    }
}