using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField] private float strength = 0;
    [SerializeField] ForceMode mode;

    Vector3 force;

    private void Start()
    {
       force = transform.forward * strength;
       //Debug.Log(force);
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 2, Color.blue);
        //Debug.Log(force);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>()!.AddForce(force, mode);
        other.GetComponentInChildren<Rigidbody>()!.AddForce(force, mode);
        //Debug.Log("ENTER");
    }

    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Rigidbody>()!.AddForce(force, mode);
        other.GetComponentInChildren<Rigidbody>()!.AddForce(force, mode);
        //Debug.Log("ENTER");
    }
}
