using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    public float speedFactor = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();       
    }

    void Update ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Debug.LogFormat("x-Axis {0} y-Axis: {1}",moveHorizontal,moveVertical);

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speedFactor);

        if (Input.GetKeyDown("space")) {
            Debug.Log("SPACE");
            rb.AddForce(0.0f,300.0f, 0.0f);
        }
    }

}

