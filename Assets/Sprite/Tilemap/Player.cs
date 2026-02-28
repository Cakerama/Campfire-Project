using UnityEditor.Callbacks;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;

    public float health;

    public float immuneTimer;

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
    }
}
