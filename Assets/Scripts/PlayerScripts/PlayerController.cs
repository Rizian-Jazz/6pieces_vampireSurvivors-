using System.Collections;
using UnityEngine;

public class PlayerController : BaseCharacterController
{
    public Rigidbody2D rb;
    public override void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public override void FixedUpdate()
    {}
    public override void OnCollisionEnter()
    {}
    public override void OnTriggerEnter()
    {}
        

}

