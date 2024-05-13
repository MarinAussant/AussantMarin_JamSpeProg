using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableBee", menuName = "Bees", order = 0)]
public class ScriptableBee : ScriptableObject
{
    public enum Capacity
    {
        SimpleSting,
        ExplosiveSting,
        SwarmSpeed,
        SwarmDamage
    };

    public Sprite sprite;
    public Color color;
    public Capacity capacity;

}
