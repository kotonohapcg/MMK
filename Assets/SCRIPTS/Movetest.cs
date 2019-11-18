using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movetest : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //アナログスティックで移動する場合
        if(OVRInput.GetDown(OVRInput.RawButton.LThumbstickUp)) {
            //transform.Translate(0, 0, (Vector3.right * 0.1f));
            transform.Translate(0, 0, 1f);
        }
        if(OVRInput.GetDown(OVRInput.RawButton.LThumbstickDown)) {
            //transform.Translate(0, 0, (Vector3.right * 0.1f));
            transform.Translate(0, 0, -1f);
        }
        if(OVRInput.GetDown(OVRInput.RawButton.LThumbstickLeft)) {
            //transform.Translate(0, 0, (Vector3.right * 0.1f));
            transform.Translate(-1f, 0, 0);
        }
        if(OVRInput.GetDown(OVRInput.RawButton.LThumbstickRight)) {
            //transform.Translate(0, 0, (Vector3.right * 0.1f));
            transform.Translate(1f, 0, 0);
        }
        
    }
}
