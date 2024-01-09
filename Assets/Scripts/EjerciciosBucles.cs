using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosBucles : MonoBehaviour
{


    void Start()
    {
        Debug.Log("===EJERCICIO 1===\n");
        for (int i = 1; i <= 100; i++ )
        {
            Debug.Log(i);
        }

        Debug.Log("\n===EJERCICIO 2===\n");
        for (int i = 2; i <= 100; i+=2)
        {
            Debug.Log(i);
        }

        Debug.Log("\n===EJERCICIO 3===\n");
        for (int i = 1; i < 100; i+=2)
        {
            Debug.Log(i);
        }

        Debug.Log("\n===EJERCICIO 4===\n");
        int resultado = 1;
        for (int i = 1; i <= 10; i++)
        {
            //1 + 2 = 3 --- 3 + 3 = 6 --- 6 + 4 = 10 --- 10 + 5 = 15
            Debug.Log(resultado);
            resultado = resultado + 1;
            
        }
    }

    
}
