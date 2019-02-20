using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour {

    //timer support
    float TotalResizeSeconds = 1;
    float elapsedResizeSeconds = 0;

    //resizing control
    float ScaleFactorPerSecond = 1; //Setting this constant to 1 will make the game object double in size in the first second, triple in size over the first 2 seconds, and so on.
    int scaleFactorSignMultiplier = 1;

   
	
	// Update is called once per frame
	void Update () {
        // resize the game object
        Vector3 newScale = transform.localScale;
        newScale.x += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        newScale.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform.localScale = newScale;
    }
}
