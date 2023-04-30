using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOOK_AT_ME : MonoBehaviour
{
    public Transform cameraPos;
    public GameObject target;
    public GameObject looker;
    public float movespeed;
    

    void Start()
    {
        cameraPos = GameObject.FindWithTag("MainCamera").transform;
        target = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        // FACE THE CAMERA
        Vector3 look = new Vector3(cameraPos.position.x,transform.position.y,cameraPos.position.z);
        looker.transform.LookAt(look, transform.up);

        // RUN FROM ME
        Vector3 movement = Vector3.Normalize(target.transform.position-transform.position)*movespeed*time.deltaTime;
        transform.position += movement;
    }
}
