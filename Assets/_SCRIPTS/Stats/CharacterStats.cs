using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
    private int maxHealth = 100;
    public int currentHealth { get; private set; }
    public HealthBar healthBar;

    private Stats damage;
    private Stats amount;
    private void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void IncreaseLife(int amount)
    {
        currentHealth += amount;
        healthBar.SetHealth(currentHealth);

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
        ReloadLevel();
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
