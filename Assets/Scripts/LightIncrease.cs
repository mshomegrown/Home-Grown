using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LightIncrease : MonoBehaviour {

    [SerializeField] GameObject player;
    Light myLight;

    //Range variables
    public bool changeRange = true;
    public float rangeSpeed = 1.0f;
    public float maxRange = 10.0f;

    //Intensity
    public bool changeIntensity = true;
    public float intensitySpeed = 1.0f;
    public float maxIntensity = 10.0f;



    float startTime;

    void Start()
    {
        //if we can get room tag name or room bool
        myLight = player.GetComponent<Light>();
        startTime = Time.time;
    }

    void Update()
    {
        if (changeRange)
        {
          
           
                myLight.range = Time.time * rangeSpeed;
                if (myLight.range >= maxRange)
                {
                    changeRange = false;
                }

        }
        if (changeIntensity)
        {
            

                myLight.intensity = Time.time * intensitySpeed;
            if (myLight.intensity >= maxIntensity)
                {
                    changeIntensity = false;
                }

        }

        //if we can get room tag name or room bool


    }
}

