using JetBrains.Annotations;
using NUnit.Framework;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;

    public float health;

    public float immuneTimer;

    public Inventory playerInv;

    public bool nearChest;
    public LayerMask chestLayer;

    public TMP_Text ChestText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        rb.linearVelocity = new Vector2(hori*speed,vert*speed);
        
        // check around player for a chest using a circle cast
        float castRadius = 2f;
        RaycastHit2D chestHit = Physics2D.CircleCast(transform.position, castRadius, Vector2.zero, 0f, chestLayer);
        nearChest = hit.collider != null;

        if (chestHit)
        {
            ChestText.enabled = true;

            if (Input.GetKeyDown(KeyCode.E))
            {
                
            }
        }
        else
        {
            ChestText.enabled = false;
        }

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<ItemOb>())
        {
            ItemOb item = collision.GetComponent<ItemOb>();
            playerInv.inventory.Add(new InvItem(item.ItemName,item.ItemSprite));
            item.gameObject.SetActive(false);


        }
    }
}
