using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 10f;
    
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
        float posZ = transform.position.z;
        float posY = transform.position.y;
        //print(transform.position.z);
        float desplY = Input.GetAxis("Vertical");
       // transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
        float desplZ = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        //restrinjir movimiento en z
        if (posZ < 12 && posZ > -12 || posZ < -12 && desplZ > 0 || posZ > 12 && desplZ < 0)
        { 
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        
        }
        //restrinjir movimiento en y
        if (posY < 10 && posY > 0.3 || posY < 0.3 && desplY > 0 || posY > 10 && desplY < 0)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);

        } 

    }
}
