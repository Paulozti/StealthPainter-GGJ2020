using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class AlarmLight : MonoBehaviour
{
    Light2D light;
    bool goingUp = false;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!goingUp)
        {
            light.intensity -= 0.007f;
            if(light.intensity < 0.1f)
                goingUp = true;
        }
        else
        {
            light.intensity += 0.007f;
            if (light.intensity > 0.4f)
                goingUp = false;
        }
        
    }
}
