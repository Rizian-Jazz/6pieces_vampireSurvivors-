using UnityEngine;

public abstract class BaseCharacterController : MonoBehaviour
{
   public abstract void Start();
   public abstract void FixedUpdate();
   public abstract void OnCollisionEnter2D(Collision2D collision);
   public abstract void OnTriggerEnter2D(Collider2D collision);
}
