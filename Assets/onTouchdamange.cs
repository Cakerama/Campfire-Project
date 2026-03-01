using UnityEngine;

public class onTouchdamange : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("AHH");
        if (collision.gameObject.CompareTag("Player"))
        {
            playerhealth player = collision.gameObject.GetComponent<playerhealth>();

            if (player != null)
            {
                player.TakeDamage(5);
            }
        }
    }
    


}
