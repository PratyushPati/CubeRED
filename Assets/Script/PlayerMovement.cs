using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    //public float forwardforce = 100f;
    public float sideforce = 50f;
    public Transform t;
    private float ScreenWidth;
    void Start()
    {
        ScreenWidth = Screen.width;
    }
    void FixedUpdate()
    {
        t.localRotation = Quaternion.identity;
        int i = 0;
        /*rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        /*float x = Input.GetAxis("Horizontal") * Time.deltaTime * sideforce;
        rb.MovePosition(rb.position + Vector3.right);*/
        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x < (ScreenWidth / 2))
            {
                rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); 
            }
            if (Input.GetTouch(i).position.x > (ScreenWidth / 2))
            {
                rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            ++i;
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y <= 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
   
}
