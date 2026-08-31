using UnityEngine;

public class HomingShots : MonoBehaviour
{
    public float bulletSpeed = 3f;
    public float rotationSpeed = 100f;
    public static Vector3 direction;

    private Rigidbody2D rb;
    private Transform target;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameObject enemyObj = GameObject.FindWithTag("Enemie");
        if (enemyObj != null)
        {
            target = enemyObj.transform;
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target == null)
        {
            AutoShots.canThrow = false;
        }
        direction = (target.position - transform.position).normalized;
        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * (rotationSpeed * 10f);
        rb.linearVelocity = transform.up * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemie")
        {
            Destroy(gameObject);
        }
    }
}
