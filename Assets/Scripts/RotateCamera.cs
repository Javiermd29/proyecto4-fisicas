using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{

    [SerializeField] private float speed;

    private float horizontalInput;

    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * speed * Time.deltaTime * horizontalInput);

    }
}
