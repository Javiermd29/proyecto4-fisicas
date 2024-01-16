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
        Debug.Log("\n===EJERCICIO 8===\n");
        int tabla = 11;
        for (int i = 1; i <= 20; i++)
        {
            Debug.Log(i + " * " + tabla + " = " + i*tabla + "\n");
        }

        Debug.Log("\n===EJERCICIO 9===\n");
        for (int i = 1; i <= 10; i++)
        {
            for (int y = 1; y <= 20; y++)
            {
                Debug.Log("Tabla de multiplicar del " + i);
                Debug.Log(y + " * " + i + " = " + y * i + "\n");
            }
            
        }


    }

    
}
