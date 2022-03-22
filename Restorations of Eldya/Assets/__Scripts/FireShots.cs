using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShots : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

        
    }

    void OnTriggerEnter2d(Collider2D hitInfo) 
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null) 
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
