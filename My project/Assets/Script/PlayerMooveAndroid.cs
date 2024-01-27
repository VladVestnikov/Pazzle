using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerMooveAndroid : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float normalSpeed;


    private void Start()    
    {
        speed = 0f;
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, rb.velocity.z);    
    }
    public void OnLeftButton()
    {
        if (speed >= 0)
        speed = -normalSpeed;
    }
    public void OnRightButton()
    {
        if (speed <= 0)
        speed = normalSpeed;
    }
    public void OnButton()
    {
        speed = 0f;
    }
}
