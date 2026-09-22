using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100, currentHealth;
    public HealthBar healthBar;
    private float damageCooldown = 1f;
    private bool isInvincible = false;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int amount)
    {
        if (isInvincible) return;
        StartCoroutine(Damage(amount));
    }

    IEnumerator Damage(int amount)
    {
        isInvincible = true;
        currentHealth -= amount;
        healthBar.SetHealth(currentHealth);
        Debug.Log("Player HP: " + currentHealth);
        if (currentHealth <= 0)
        {
            Debug.Log("Player morreu");
            Destroy(gameObject);
        }
        yield return new WaitForSeconds(damageCooldown);
        isInvincible = false;
    }

    //não tem itens de cura ainda *emoji de insatisfação*, mas fiz pq sim *emoji de riza*
    public void Heal(int amount)
    {
        currentHealth += amount;
        healthBar.SetHealth(currentHealth);
        if (currentHealth > maxHealth) currentHealth = maxHealth;
        Debug.Log("Player HP: " + currentHealth);
    }
}
