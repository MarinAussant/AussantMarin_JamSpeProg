using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeSpawner : MonoBehaviour
{

    [SerializeField] private ScriptableBee[] beeList;
    [SerializeField] private GameObject beeExemple;

    private Vector3 beePosition;


    private void Start()
    {
        SpawnNewBee();
    }

    public void SpawnNewBee()
    {

        int i = Random.Range(0, beeList.Length);
        beePosition = new Vector3(Random.Range(-15,15),Random.Range(-1.7f,10),-10);

        GameObject newBee = Instantiate(beeExemple, beePosition, transform.rotation);
        newBee.GetComponent<SpriteRenderer>().color = beeList[i].color;

    }

    public Vector3 GetBeePosition()
    {
        return beePosition;
    }

}
