using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : BaseCharacterController
{
    
    public float moveSpeed = 6f;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public override void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public override void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * moveSpeed;
    }
    public void onMove(InputAction.CallbackContext context)
    {
          moveDirection = new Vector2(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y);;
    }
    public override void OnCollisionEnter()
    {
        //nada aqui ainda
    }
    public override void OnTriggerEnter()
    {
        //nada aqui ainda
    }
    public override void Attack()
    {
        //nada aqui ainda
    }
        
}

