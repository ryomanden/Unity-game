using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Rigidbody rig;

    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            rig.AddForce(transform.forward * 5f);
        } else if(Input.GetKey(KeyCode.S)) {
            rig.AddForce(transform.forward * -5f);
        }

        float mouse_x = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, mouse_x * 1f);
    }
}
