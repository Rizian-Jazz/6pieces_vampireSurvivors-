using UnityEngine;

public class HomingShots : MonoBehaviour
{
    public float bulletSpeed = 3f;
    public float rotationSpeed = 100f;

    private Rigidbody2D rb;
    private Transform target;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Enemie").transform;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var direction = (target.position - transform.position).normalized;
        float rotateAmount = Vector3.Cross(direction, transform.up).z;

        rb.angularVelocity = -rotateAmount * rotationSpeed;
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
