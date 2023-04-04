using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForces : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] ForceMode forceMode;
    [SerializeField] Vector3 torque;
    [SerializeField] ForceMode torqueMode;
    [SerializeField] bool isRelative = false;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        if (isRelative)
        {
            rb.AddRelativeForce(force, forceMode);
        }
        else
        {
            rb.AddForce(force, forceMode);
        }
        
        if (isRelative)
        {
            rb.AddRelativeTorque(torque, torqueMode);
        }
        else
        {
            rb.AddTorque(torque, torqueMode);
        }

        // draw axis
        Debug.DrawRay(transform.position, transform.forward * 2, Color.blue);
        Debug.DrawRay(transform.position, transform.right * 2, Color.red);
        Debug.DrawRay(transform.position, transform.up * 2, Color.green);

    }
}
