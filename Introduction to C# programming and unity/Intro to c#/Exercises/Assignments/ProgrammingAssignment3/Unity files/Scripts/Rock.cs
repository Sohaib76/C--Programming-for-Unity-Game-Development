using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour {


    // explosion support
   // [SerializeField]
    //GameObject prefabExplosion;

    // death support
    const float rockLifespanSeconds = 10;
    Timer deathTimer;


    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // apply impulse force to get game object moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 2f;
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);
    }


    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // kill rock if death timer finished
       // if (deathTimer.Finished)
        //{
          //  Destroy(gameObject);
        //}
    }

    /// <summary>
    /// Checks whether or not to blow up
    /// </summary>
    /// <param name="coll">collision info</param>
   // void OnCollisionEnter2D(Collision2D coll)
   // {
        // only blow up when colliding with a teddy bear
   //     if (coll.gameObject.tag == "Rock")
    //    {
     //       Instantiate<GameObject>(prefabExplosion, transform.position, Quaternion.identity);
     //       Destroy(gameObject);
    //    }
   // }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
