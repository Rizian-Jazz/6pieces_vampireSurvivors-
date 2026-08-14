using UnityEngine;

public abstract class BaseCharacterController : MonoBehaviour
{
   public abstract void Start();
   public abstract void FixedUpdate();
   public abstract void OnCollisionEnter();
   public abstract void OnTriggerEnter();
   public abstract void Attack();
}
