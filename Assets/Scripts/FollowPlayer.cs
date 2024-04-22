using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private float speed;

    private void Update()
    {
        Vector3 tempPosition = Vector3.Lerp(transform.position, player.transform.position, speed*Time.deltaTime);
        tempPosition.z = -10;
        transform.position = tempPosition;
    }
}
