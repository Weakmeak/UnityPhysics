using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyTranslation : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] Vector3 torque;
    [SerializeField] bool isRelative = false;

    private void Start()
    {
    }

    private void Update()
    {

        transform.Translate(force * Time.deltaTime, isRelative ? Space.Self : Space.World);
        transform.Rotate(torque * Time.deltaTime, isRelative ? Space.Self : Space.World);

    }
}
