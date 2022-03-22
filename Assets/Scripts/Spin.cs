using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public GameObject item;
    private float speed = 10f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb2d.AddForce(new Vector2(horizontalInput*speed,verticalInput*speed));
        float speedInUnitPerSecond = rb2d.velocity.magnitude;

        Debug.Log(speedInUnitPerSecond);
    }
}
