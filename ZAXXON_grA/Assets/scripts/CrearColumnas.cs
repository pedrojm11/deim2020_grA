using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearColumnas : MonoBehaviour
{
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    float distancia = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ColumnCorrutine");
        InicioColumna();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            CrearColumna();
        }

    }
    void InicioColumna()
    {
        for (int n = 0; n < 20; n++)
        {
            //Creo un nuevo vector3
            float posRandomZ = Random.Range(0f, 30f);
            float posRandomY = Random.Range(-2f, 10f);
            Vector3 DestPos = new Vector3(n*distancia, posRandomY, posRandomZ);
            Vector3 NewPos = RefPos.position + DestPos;
            //Instancio el prefab en la posición del objeto de referencia
            //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
            Instantiate(MyColumn, NewPos, Quaternion.identity);
        }
    }

    void CrearColumna()
    {
        //Creo un nuevo vector3
        float posRandomZ = Random.Range(0f, 30f);
        float posRandomY = Random.Range(-2f, 10f);
        Vector3 DestPos = new Vector3(0, posRandomY, posRandomZ);
        Vector3 NewPos = RefPos.position + DestPos;
        //Instancio el prefab en la posición del objeto de referencia
        //Como tenemos su componente Transform, le indicamos que lo que quiero es su posición
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }

    IEnumerator ColumnCorrutine()
    {

        for (int n=0; ; n++ )
        {
            print(n);
            //Intancio el prefab en coordenadas 0,0,0
            //Instantiate(MyColumn);
            CrearColumna();
            yield return new WaitForSeconds(0.1f);
        }
    }
}
