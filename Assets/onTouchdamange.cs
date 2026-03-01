using UnityEngine;

public class onTouchdamange : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerhealth player = collision.gameObject.GetComponent<playerhealth>();

            if (player != null)
            {
                player.TakeDamage(+5);
            }
        }
    }
    


}
