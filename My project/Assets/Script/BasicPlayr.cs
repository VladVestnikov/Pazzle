using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayr : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    float MoveHorizontal;
    float MoveVertical;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(MoveHorizontal, 0.0f, MoveVertical);

        rb.AddForce(movement * speed);
    }
    public void Up()
    {
        MoveVertical = 1f;
    }
    public void Down()
    {
        MoveVertical = -1f;
    }
    public void StopMoveVertical()
    {
        MoveVertical = 0f;
    }
    public void Left()
    {
        MoveHorizontal = -1f;
    }
    public void Right()
    {
        MoveHorizontal = 1f;
    }
    public void StopMove()
    {
        MoveHorizontal = 0f;
    }
}
