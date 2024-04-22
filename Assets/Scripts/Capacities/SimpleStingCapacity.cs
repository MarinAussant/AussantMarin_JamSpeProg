using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStingCapacity : Capacity
{

    [SerializeField] private float dmg = 15;

    public override void Activate(GameObject target)
    {

        target.GetComponent<Ennemis>().TakeDamage(dmg);

    }

}
