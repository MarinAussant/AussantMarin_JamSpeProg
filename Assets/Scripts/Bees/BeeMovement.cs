using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeMovement : MonoBehaviour
{

    [SerializeField] private float movementRange = 1.0f;
    [SerializeField] private float movementSpeed = 1.0f;
    [SerializeField] private float maxRandomDelay = 0.5f;
    private Vector2 startPosition;
    private Vector2 offset;
    private bool isFollowing = false;

    private void Start()
    {
        startPosition = transform.position;
        offset = Random.insideUnitCircle.normalized * Random.Range(1.25f,2.5f);

        StartCoroutine(FreeFly());

    }

    IEnumerator FreeFly()
    {
        while (isFollowing == false)
        {
            float randomDelay = Random.Range(0f, maxRandomDelay);
            yield return new WaitForSeconds(randomDelay);

            Vector2 randomDirection = Random.insideUnitCircle.normalized;
            Vector2 targetPosition = startPosition + randomDirection * movementRange;

            while (Vector2.Distance((Vector2)transform.position, targetPosition) > 0.05f)
            {
                transform.position = Vector2.Lerp(transform.position, targetPosition, movementSpeed * Time.deltaTime);
                yield return null;
            }

        }

        startPosition = FindObjectOfType<MovementScript>().gameObject.transform.position + (Vector3)offset;
        StartCoroutine(FollowQueenMovement());
    }

    IEnumerator FollowQueenMovement()
    {
        while (true)
        {
            float randomDelay = Random.Range(0f, maxRandomDelay);
            yield return new WaitForSeconds(randomDelay);

            Vector2 randomDirection = Random.insideUnitCircle.normalized;
            Vector2 targetPosition = startPosition + randomDirection * movementRange;

            while (Vector2.Distance((Vector2)transform.position, targetPosition) > 0.05f)
            {
                transform.position = Vector2.Lerp(transform.position, targetPosition, movementSpeed * Time.deltaTime);
                yield return null;
            }

            startPosition = FindObjectOfType<MovementScript>().gameObject.transform.position + (Vector3)offset;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && !isFollowing)
        {
            isFollowing = true;
            FindObjectOfType<BeeSpawner>().SpawnNewBee();
        }
    }

}
