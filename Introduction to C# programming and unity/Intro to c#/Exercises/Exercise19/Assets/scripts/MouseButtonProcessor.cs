using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    Animator anim;


    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
	{
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0)
        {
            // only spawn character on first input frame
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;
                // convert mouse position to world position
                Vector3 position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                position = Camera.main.ScreenToWorldPoint(position);
                GameObject teddyBear = Instantiate(prefabTeddyBear) as GameObject;
                teddyBear.transform.position = position;
            }
            
        }
        else
        {
            // no change character input
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
        if(Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;

                GameObject teddy = GameObject.FindWithTag("TeddyBear");
                if (teddy != null)
                {
                    Instantiate(prefabExplosion, teddy.transform.position, Quaternion.identity);
                    Destroy(teddy);
                }
            }

        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }

		
	}
}
