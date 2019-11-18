using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JudgeDestroyColl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi");
    }

    public void OnCollisionEnter(Collision other)
    {
            if (other.gameObject.name == "JudgeCollision")
            {
                Debug.Log("Destroy");
                Destroy(gameObject);
            }
    }

    // void onTriggerEnter(Collider others)
    // {
    //     if(others.tag == "YURI")
    //     {
    //         Destroy(gameObject);
    //     }
    // }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//このコードをCARROTにAttachして、実行する。