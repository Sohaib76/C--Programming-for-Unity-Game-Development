using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newJumper : MonoBehaviour {


    //  jump  location  support
    float minX = -4.92f;
    float maxX = 4.92f;
    float minY = -2.29f;
    float maxY = 2.29f;


    float elapsedJumpDelaySeconds= 0;
    float totalJumpDelaySeconds = 0.0005f;


    // Update is called once per frame
    void Update () {

        //  update  timer  and  check  if  it is done


        elapsedJumpDelaySeconds += Time.deltaTime;
        if (elapsedJumpDelaySeconds >= totalJumpDelaySeconds)

        {
            elapsedJumpDelaySeconds = 0;
            transform.position = new Vector3
            (
                Random.Range(minX, maxX),
                Random.Range(minY, maxY),
                0


            );
        }
    }
}
