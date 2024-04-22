using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemis : MonoBehaviour
{

    private float hp;
    private Sprite sprite;

    private void Update()
    {
        
        if (hp <= 0)
        {
            GetComponent<Renderer>().enabled = false;
        }

    }

    public void TakeDamage(float dmg)
    {
        hp -= dmg;
    }

    public void TakePoisonusDamage(float dmg)
    {
        hp -= dmg;
    }

    public void SpriteReset(float hp, Sprite sprite)
    {
        this.hp = hp;
        GetComponent<SpriteRenderer>().sprite = sprite;
        GetComponent<Renderer>().enabled = true;
        GetComponent<SpriteRenderer>().color = Color.HSVToRGB(Random.Range(0f, 1f), 0.35f, 1, false);
    }

    public float GetHp() { return hp; }



}
