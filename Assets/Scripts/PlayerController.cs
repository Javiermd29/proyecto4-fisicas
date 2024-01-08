using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidBody;
    [SerializeField] private float speed = 30f;
    private float forwardInput;

    [SerializeField] private GameObject focalPointGameObject;

    private bool hasPowerUp;

    [SerializeField]private float powerUpForce = 100f;


    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        hasPowerUp = false;
    }
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

       /* if (Mathf.Abs(forwardInput) < 0.01f)
        {
            playerRigidBody.velocity = Vector3.zero;
        }
        else
        {
            playerRigidBody.AddForce(focalPointGameObject.transform.forward * speed * forwardInput);
        } */

        playerRigidBody.AddForce(focalPointGameObject.transform.forward * speed * forwardInput);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            StartCoroutine (PowerUpCountdown());
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            //El enemigo sufre un empujón alejándolo del player
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();

            Vector3 direction = (collision.transform.position - transform.position).normalized;

            enemyRigidbody.AddForce(direction * powerUpForce, ForceMode.Impulse);
        }
    }

    private IEnumerator PowerUpCountdown()
    {
        yield return new WaitForSeconds(6);

        hasPowerUp = false;
    }

}
