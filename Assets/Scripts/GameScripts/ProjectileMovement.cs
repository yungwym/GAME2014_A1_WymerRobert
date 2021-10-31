using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private float damage;
    private float fireSpeed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        transform.position += transform.up * fireSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

    public void SetDamage(float dam)
    {
        damage = dam;
    }

    public float GetDamage()
    {
        return damage;
    }
}
