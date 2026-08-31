using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using System.Collections;

public class AutoShots : MonoBehaviour
{   
        public GameObject bulletPrefab;
        public UnityEvent fireEvent;
        public static float bulletSpeed = 10f, bulletInterval = 0.7f;
        public Transform firePoint; 
        public static bool canThrow = true;


    public void Start()
    {
        StartCoroutine(FireLoop());
    } 
    
    IEnumerator FireLoop()
    {
        while (canThrow == true)
        {
            
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

            Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();
            if (bulletRb != null)
            {
                bulletRb.linearVelocity = firePoint.up * bulletSpeed;
            }

            yield return new WaitForSeconds(bulletInterval);
        }            
    }
}
