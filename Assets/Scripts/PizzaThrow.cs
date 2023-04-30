using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaThrow : MonoBehaviour
{
    public Rigidbody pizza;
    public float throwSpeed;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            Rigidbody thrownPizza;
            thrownPizza = Instantiate(pizza, transform.position + new Vector3(0, 0, 1), transform.rotation);
            thrownPizza.velocity = transform.TransformDirection(new Vector3(0, 3, throwSpeed));
        }
    }
}
