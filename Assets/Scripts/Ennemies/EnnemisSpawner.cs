using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemisSpawner : MonoBehaviour
{

    [SerializeField] Ennemis[] spawnPositions;
    [SerializeField] ScriptableEnnemis[] ennemisList;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnMob());
    }

    public IEnumerator spawnMob()
    {
        while (true)
        {

            foreach (Ennemis slot in spawnPositions)
            {
                if (slot.GetHp() <=0)
                {
                    ScriptableEnnemis scriptableEnnemis = ennemisList[Random.Range(0,ennemisList.Length)];
                    slot.SpriteReset(scriptableEnnemis.hp, scriptableEnnemis.sprite);
                }
            }

            yield return new WaitForSeconds(2f);
        }
    }
}
