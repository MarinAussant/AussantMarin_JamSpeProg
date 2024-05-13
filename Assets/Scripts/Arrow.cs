using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Position Fleche
        Vector3 thePosition = FindObjectOfType<MovementScript>().transform.position;
        thePosition.y += 1.5f;
        transform.position = thePosition;

        //Angle Fleche
        Vector3 direction = FindObjectOfType<BeeSpawner>().GetBeePosition() - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f,angle);
    }
}
