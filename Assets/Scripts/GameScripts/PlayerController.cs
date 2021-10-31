using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float playerHealth = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(20.0f);
            Debug.Log(playerHealth);
        }
    }


    private void TakeDamage(float damage)
    {
        playerHealth -= damage;
    }

    public float GetPlayerHealth()
    {
        return playerHealth;
    }

    public bool PlayerDeath()
    {
        if (playerHealth <= 0)
        {
            return true;
        }
        return false;
    }
}
