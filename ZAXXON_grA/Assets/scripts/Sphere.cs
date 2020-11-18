﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 2.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Método para mover la nave con el joystick
        MoverNave();

    }

    void MoverNave()
    {
        print(transform.position.z);
        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        float desplZ = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * Time.deltaTime * speed * desplZ);


    }
}
