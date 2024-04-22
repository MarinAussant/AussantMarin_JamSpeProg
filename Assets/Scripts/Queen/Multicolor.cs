using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multicolor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    [SerializeField] private float changeSpeed;
    private float timeStamp = 0;
    private Color finalColor;

    void Start()
    {

        finalColor = Color.HSVToRGB(Random.Range(0f, 1f), 0.27f, 1);
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void Update()
    {
        timeStamp += Time.deltaTime;

        if (timeStamp >= changeSpeed)
        {

            timeStamp = 0;
            finalColor = Color.HSVToRGB(Random.Range(0f, 1f), 1f, 1, true);


        }

        //spriteRenderer.color = Color.Lerp(spriteRenderer.color, finalColor, (timeStamp/changeSpeed) * Time.deltaTime );

    }

}
