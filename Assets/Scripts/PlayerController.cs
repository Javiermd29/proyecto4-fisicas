using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidBody;
    [SerializeField] private float speed = 30f;
    private float forwardInput;

    [SerializeField] private GameObject focalPointGameObject;

    [SerializeField] private bool hasPowerUp;

    [SerializeField] private float powerUpForce = 100f;

    [SerializeField] private GameObject[] powerupIndicators;

    private bool isGameOver;

    private int lives;

    private float lowerLimit = -3f;

    private Vector3 initialPosition;

    void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        hasPowerUp = false;
        initialPosition = Vector3.zero;
        lives = 3;
        isGameOver = false;

    }

    private void Start()
    {
        HideAllPowerupIndicators();
    }

    void Update()
    {

        if (isGameOver)
        {
            return;
        }

        Movement();

        if (transform.position.y < lowerLimit)
        {
            lives--;
            if (lives <= 0)
            {
                //GAME OVER
                isGameOver = true;
            }
            else
            {
                transform.position = initialPosition;
                playerRigidBody.velocity = Vector3.zero;
            }
        }

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

    private void Movement()
    {

        forwardInput = Input.GetAxis("Vertical");

        playerRigidBody.AddForce(focalPointGameObject.transform.forward * speed * forwardInput);

    }

    private IEnumerator PowerUpCountdown()
    {

        for (int i = 0; i < powerupIndicators.Length; i++)
        {
            powerupIndicators[i].SetActive(true);
            yield return new WaitForSeconds(2);
            powerupIndicators[i].SetActive(false);

        }

        hasPowerUp = false;
    }

    private void HideAllPowerupIndicators()
    {

        foreach (GameObject indicator in powerupIndicators)
        {
            indicator.SetActive(false);
        }

    }

    public bool GetIsGameOver()
    {
        return isGameOver;
    }

}
