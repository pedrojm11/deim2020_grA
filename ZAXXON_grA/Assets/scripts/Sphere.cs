using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sphere : MonoBehaviour
{
    public float speed = 10f;
    [SerializeField] Text speedText;
    [SerializeField] Text timeText;
    private string currentTime;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Método para mover la nave con el joystick
        MoverNave();
        //Cambio el texto de la UI, metido en la variable speedText. Debe ser una cadena, si quiero, puedo convertir el float en string //speedText.text = speed.ToString();
        speedText.text = "Velocidad: " + speed + " Km/h";

        // Obtain the current time.
        currentTime = Time.time.ToString("f2");
        currentTime = " " + currentTime + " ";

        timeText.text = currentTime;


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
