using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
{
    Rigidbody2D bulletRigidBody;
    public float speed;
    public int damage = 1;

    // Start is called before the first frame update
    void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        bulletRigidBody.AddForce(-Vector2.up * speed);
        Invoke("Disable", 5f);
    }


    private void Disable()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().TakeDamage(damage);
            Invoke("Disable", 0.001f);
        }
    }
}
