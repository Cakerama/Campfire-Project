using UnityEngine;

public class Pokemon : MonoBehaviour
{

    public float findRadius;

    public float playerfindRadius;
    public LayerMask EnemyLayer;
    public float speed;
    public float DeadZone = 2f;
    public Rigidbody2D rb;
    public LayerMask PlayerLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void FixedUpdate()
    {
      



        RaycastHit2D EnemyHit = Physics2D.CircleCast(transform.position, findRadius, Vector2.zero, 0f, EnemyLayer);
        RaycastHit2D PlayerHit = Physics2D.CircleCast(transform.position, playerfindRadius, Vector2.zero, 0f, PlayerLayer);
        float playerDistance = Vector2.Distance(transform.position,PlayerHit.transform.position);
        if (EnemyHit.collider != null)
        {
            Vector2 direction = (EnemyHit.collider.transform.position - transform.position).normalized;
            rb.linearVelocity = direction * speed;
        }
        else if(playerDistance>=DeadZone)
        {
             Vector2 direction = (PlayerHit.collider.transform.position - transform.position).normalized;
            rb.linearVelocity = direction * speed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }


   







    }



    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<enemyaiainew>())
            {
                collision.gameObject.GetComponent<enemyaiainew>().TakeDamage(5);
            }
    }


    
}
