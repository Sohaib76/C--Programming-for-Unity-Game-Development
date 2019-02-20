using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    /// <summary>
    /// Control spawning of rocks
    /// </summary>
    /// 

    //Rock prefab
    [SerializeField]
    GameObject rockPrefab;

    [SerializeField]
    Sprite rockSprite0;
    [SerializeField]
    Sprite rockSprite1;
    [SerializeField]
    Sprite rockSprite2;


    //timer for spawning every second
    Timer spawnTimer;


    // Use this for initialization
    void Start()
    {

        //add a timer component to the object this script is attached to
        spawnTimer = gameObject.AddComponent<Timer>();

        //how long should the timer run
        spawnTimer.Duration = 1;

        //start running
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {


        //Check if 1 second has passed 
        if (spawnTimer.Finished)
        {

            //restart timer
            spawnTimer.Run();




            //Check if there are less than 3 rocks
            if (GameObject.FindGameObjectsWithTag("Rock").Length < 3)

            {
                //spawn a rock 
                SpawnRock();
            }



        }

    }

    void SpawnRock()
    {
        Vector3 location = new Vector3(0, 0, -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject rock = Instantiate(rockPrefab) as GameObject;
        rock.transform.position = worldLocation;

        // set random sprite for each new rock
        SpriteRenderer spriteRenderer = rock.GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber == 0)
        {
            spriteRenderer.sprite = rockSprite0;
        }
        else if (spriteNumber == 1)
        {
            spriteRenderer.sprite = rockSprite1;
        }
        else
        {
            spriteRenderer.sprite = rockSprite2;
        }
    }
}