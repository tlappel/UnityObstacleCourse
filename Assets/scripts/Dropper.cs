using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private bool dropped = false;
    [SerializeField] float dropWaitTime = 10f;
    MeshRenderer renderer;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rb.useGravity = false;
    }


    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag =="Ground")
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!dropped)
        {
            if(Time.time > dropWaitTime)
            {
                renderer.enabled = true;
                rb.useGravity = true;
                dropped = true;
            }
        }
        
    }
}
