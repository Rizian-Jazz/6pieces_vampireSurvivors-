using UnityEngine;

public class HomingShots : MonoBehaviour
{
    public float bulletSpeed = 3f;
    public float rotationSpeed = 100f;
    public static Vector3 direction;

    private Rigidbody2D rb;
    private Transform target;
    public static int bulletDamage = 20; 
    /*seria pog fazer um manager pra tiros no geral pra esse valor mudar de acordo com a bala né
    pq o EnemieHealth ta tomando dano só dessa bala, ai como eu 'riza' não quero tem um milhão de linhas pra cada bala
    um dia eu faço um manager pra elas. *emoji de flor caida**/
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject enemyObj = GameObject.FindWithTag("Enemie");
        if (enemyObj != null)
        {
            target = enemyObj.transform;
        }
        
    }

    void FixedUpdate()
    {
        if (target == null)
        {
            AutoShots.canThrow = false;
        }
        direction = (target.position - transform.position).normalized;
        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * (rotationSpeed * 10f);
        rb.linearVelocity = direction * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemie")
        {
            Destroy(gameObject);
        }
    }
}
