using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaThrow : MonoBehaviour
{
    public Rigidbody pizza;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R)) {
            Rigidbody thrownPizza;
            thrownPizza = Instantiate(pizza, transform.position, transform.rotation);
            thrownPizza.velocity = transform.TransformDirection(Vector3.forward * 20);
        }
    }
}
