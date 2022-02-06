using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float OBspeed=1300;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.back * speed * Time.deltaTime);
        rb.AddForce(0, 0, -OBspeed * Time.deltaTime);
        if (transform.position.z < -79f)
        {
            Destroy(gameObject);
        }
    }
}
