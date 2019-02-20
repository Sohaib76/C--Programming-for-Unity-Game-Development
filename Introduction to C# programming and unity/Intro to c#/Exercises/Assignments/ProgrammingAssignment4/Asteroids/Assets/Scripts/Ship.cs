using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Provides input for ship
/// </summary>
public class Ship : MonoBehaviour {

    public float radius;


    const int RotateDegreesPerSecond = 60;

    const float ThrustForce  = 6f;
    Vector2 thrustDirection = new Vector2(1, 0);

    private Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
       rb2D =  gameObject.GetComponent<Rigidbody2D>();
       radius = gameObject.GetComponent<CircleCollider2D>().radius;
        
	}

    // Update is called once per frame
    void Update()
    {
        //rotation of ship
        float rotationInput = Input.GetAxis("Rotate");
        if (rotationInput != 0)
      { 
        //  calculate rotation amount and apply rotation 
        float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
        if (rotationInput < 0)
        {
            rotationAmount *= -1;
        }
        transform.Rotate(Vector3.forward, rotationAmount);


         
        float direction = transform.eulerAngles.z;
        direction *= Mathf.Deg2Rad;
        thrustDirection.x = Mathf.Cos(direction);
        thrustDirection.y = Mathf.Sin(direction);
        }



    }

    /// <summary>
    /// This is a fixed update
    /// </summary>
    void FixedUpdate()
    {
        if(Input.GetAxis("Thrust") > 0)
        {
          //  Debug.Log(radius);
            rb2D.AddForce(ThrustForce * thrustDirection, ForceMode2D.Force);
        }
       // rb2D.AddForce(10.0f * Vector2.up);
    }


    /// <summary>
    /// On Became Visible method
    /// </summary>
    void OnBecameInvisible()
    {
        //enabled = false;
       // FIXME_VAR_TYPE cam = Camera.main;

       // Vector2 viewportPosition = cam.WorldToViewportPoint(transform.position);

        Vector2 newPosition = transform.position;

        if (transform.position.x - radius >= ScreenUtils.ScreenRight)
        {
            newPosition.x = ScreenUtils.ScreenLeft;
        }
        else if (transform.position.x + radius <= ScreenUtils.ScreenLeft)
        {
            newPosition.x = ScreenUtils.ScreenRight;
        }

        if (transform.position.y - radius >= ScreenUtils.ScreenTop)
        {
            newPosition.y = ScreenUtils.ScreenBottom;
        }
        else if (transform.position.y + radius <= ScreenUtils.ScreenBottom)
        {
            newPosition.y = ScreenUtils.ScreenTop;
        }
        /*
        if (viewportPosition.x > 1 || viewportPosition.x < 0)
        {
            newPosition.y = -newPosition.y;
        }

        if (viewportPosition.y > 1 || viewportPosition.y < 0)
        {
            newPosition.y = -newPosition.y;
        }

    */

        transform.position = newPosition;
    }
}
