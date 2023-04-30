using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float gravityModifier;
    public float jumpHeight;
    public bool isGrounded;
    public bool lookDirection;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Walk
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            lookDirection = false;
        }

        //Jump
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
                isGrounded = false;
            }
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        //Determines whether player can jump
        if (collider.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
