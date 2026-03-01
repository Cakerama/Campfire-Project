using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class enemyaiainew : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public float findRadius = 10f;
    private Rigidbody2D rb;
    public LayerMask PlayerLayer;
    public float acccooldown;
    public float cooldown;

    public float health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        RaycastHit2D PlayerHit = Physics2D.CircleCast(transform.position, findRadius, Vector2.zero, 0f, PlayerLayer);

        if (PlayerHit.collider != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            rb.linearVelocity = direction * speed;
        }
        else
        {
  rb.linearVelocity = new Vector2(0,0);          
      
        }
    }
    public void TakeDamage(int damage)
    {
        Debug.Log("ad");
        if (acccooldown <= 0f)
        {
            health -= damage;
            acccooldown = cooldown;
        }
        if (health <= 0)
        {
            Destroy(gameObject);

        }
    }

    

      }
    

