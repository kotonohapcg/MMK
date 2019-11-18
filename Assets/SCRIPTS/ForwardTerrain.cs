using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardTerrain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z >= 13.999) {
            this.transform.position = new Vector3(9.9f, 0.251f, -6.3f);
        }
        
    }
}
