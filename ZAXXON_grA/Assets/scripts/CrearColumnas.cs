using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
        
    // Start is called before the first frame update
    void Start()
    {
        //Intancio el prefab en coordenadas 0,0,0
        //Instantiate(MyColumn);

        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyColumn, RefPos.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
