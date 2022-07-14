using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductTest : MonoBehaviour
{
    public Transform Target;

    // Update is called once per frame
    void Update()
    {
        Vector3 distanceVector = Target.position - transform.position;
        Debug.Log(Vector3.Dot(transform.forward, distanceVector.normalized));
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
        Debug.DrawRay(transform.position, distanceVector, Color.red);

        Vector3 Nomalized = Vector3.Cross(transform.forward, distanceVector.normalized);
        Debug.DrawRay(transform.position, Nomalized, Color.green);
        Debug.Log($"Cross {Nomalized.normalized}");

    }
}
