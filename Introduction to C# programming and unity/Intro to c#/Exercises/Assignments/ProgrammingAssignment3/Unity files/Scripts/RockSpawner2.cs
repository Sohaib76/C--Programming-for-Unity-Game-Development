using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner2 : MonoBehaviour
{
    [SerializeField]
    GameObject prefabrock;

    //saved for efficiency
    [SerializeField]
    Sprite greenrock0;
    [SerializeField]
    Sprite whiterock2;
    [SerializeField]
    Sprite magentarock1;


    int rockcount;

    //spawn location support
    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    // Use this for initialization
    void Start()
    {
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;


    }

    // Update is called once per frame
    void Update()
    {
        rockcount = GameObject.FindGameObjectsWithTag("Rock").Length;
        //Debug.Log(rockcount);
        if (rockcount < 3)
        {
            SpawnRock();
        }
    }


    void SpawnRock()
    {

        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
                               Random.Range(minSpawnY, maxSpawnY),
                               -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(prefabrock) as GameObject;
        rock.transform.position = Vector3.zero;


        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = greenrock0;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = magentarock1;
        }
        else
        {
            spriteRenderer.sprite = whiterock2;
        }
    }
}


