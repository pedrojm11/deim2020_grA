using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columna : MonoBehaviour
{

    private Vector3 Pepe = new Vector3();
    private Sphere Jose = new Sphere();


    private Vector3 MyPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;

    Sphere Personaje = new Sphere();

    float mySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        mySpeed = Personaje.speed;
        print(mySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        MyPos = transform.position;
        FinalPos = MyPos + DestPos * Time.deltaTime * mySpeed;
        transform.position = FinalPos;
        //print(MyPos);
    }
}
