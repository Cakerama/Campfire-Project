using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public int maxHealth = 100;

    public Player player;

    public float cooldown = 1f;
    public float acccooldown;
    void Start()
    {
         player.health = maxHealth;
    }

    void Update()
    {
        if (acccooldown > 0)
        {
            acccooldown -= Time.deltaTime;

        }
    }



    public void TakeDamage(int damage)
    {
        Debug.Log("ad");
        if (acccooldown <= 0f)
        {
            player.health -= damage;
            acccooldown = cooldown;
        }
        if (player.health <= 0)
        {
            Destroy(gameObject);

        }
    }
}
