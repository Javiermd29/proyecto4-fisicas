using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    [SerializeField] private int[] intArray;

    private int whileIndex;

    void Start()
    {

        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("Hola");
        }

        for (int i = 1; intArray.Length<= 10; i++)
        {
            Debug.Log("{intArray[i]}");
        }

        foreach (int numb in intArray)
        {
            Debug.Log($"{numb}");
        }

        whileIndex = 1;

        while (whileIndex <= 10)
        {
            Debug.Log($"whileIndex = {whileIndex}");
            whileIndex++;
        }

    }
}
