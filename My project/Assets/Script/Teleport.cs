using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tele : MonoBehaviour
{
    public Vector3 Teleport_Point;
    private void OnTriggerStay(Collider other)
    {
            other.transform.position = Teleport_Point;
    }
}
