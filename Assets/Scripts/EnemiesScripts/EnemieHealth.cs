using UnityEngine;

public class EnemieHealth : EnemieManager
{
    public int EnemyHealth = 100;
    public int EnemyDamage = 5;

    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Enemy hit by bullet! -" + HomingShots.bulletDamage + " HP");
            EnemyHealth -= HomingShots.bulletDamage;
            if(EnemyHealth <= 0)
            {
                Destroy(gameObject);
            }
        }  
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(EnemyDamage);
                Debug.Log("Enemy collided with player! Player takes " + EnemyDamage + " damage.");
            }
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
}}
