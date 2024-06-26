using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, whatIsSolid);

        if (lifeTime > 0)
        {
            if (hitInfo.collider != null)
            {
                if (hitInfo.collider.CompareTag("Enemy"))
                {
                    hitInfo.collider.GetComponent<Enemy>().TakeDamage(damage);
                }
                Destroy(gameObject);
            }
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            lifeTime -= Time.deltaTime;
        } 
        else
        {
            Destroy(gameObject);
        }

    }
}
