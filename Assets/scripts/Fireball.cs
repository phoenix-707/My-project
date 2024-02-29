using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float damage = 10;

    void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    private void MoveFixedUpdate()
    {
        transform.position += transform.forward * speed * Time.fixedDeltaTime;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        DamageEnemy(collision);
        DestroyFireBall();
    }

    private void DamageEnemy(Collision collision)
    {
        var enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.DealDamage(damage);
        }
    }


    private void DestroyFireBall()
    {
        Destroy(gameObject);
    }

    void Start()
    {
        Invoke("DestroyFireBall", lifeTime); 
    }


    void Update()
    {
        
    }
}
