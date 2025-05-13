using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        if(Mathf.Abs(xInput) > 0)
        {
            rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        }

        if(Mathf.Abs(yInput) > 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, yInput * speed);
        }

        //Vector2 direction = new Vector2(xInput, yInput).normalized;
        //rb.velocity = direction * speed;
    }
}
