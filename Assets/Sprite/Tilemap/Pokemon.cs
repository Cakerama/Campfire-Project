using UnityEngine;

public class Pokemon : MonoBehaviour
{

    public float findRadius;
    public LayerMask EnemyLayer;
    public float speed;
    public Rigidbody2D rb;
    public LayerMask PlayerLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void FixedUpdate()
    {
      



        RaycastHit2D EnemyHit = Physics2D.CircleCast(transform.position, findRadius, Vector2.zero, 0f, EnemyLayer);
        RaycastHit2D PlayerHit = Physics2D.CircleCast(transform.position, findRadius*2, Vector2.zero, 0f, PlayerLayer);
        if (EnemyHit.collider != null)
        {
            Vector2 direction = (EnemyHit.collider.transform.position - transform.position).normalized;
            rb.linearVelocity = direction * speed;
        }
        else
        {
             Vector2 direction = (PlayerHit.collider.transform.position - transform.position).normalized;
            rb.linearVelocity = direction * speed;
        }


   







    }


     void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.gameObject.GetComponent<enemyaiainew>())
            {
                collision.collider.gameObject.GetComponent<enemyaiainew>().TakeDamage(10);
            }
    }
}
