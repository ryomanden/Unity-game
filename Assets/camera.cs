using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update


    public Transform target;
    public Vector3 offset;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       offset = new Vector3(2, 2, -5);
       this.transform.position = target.position + offset;
    }
}
