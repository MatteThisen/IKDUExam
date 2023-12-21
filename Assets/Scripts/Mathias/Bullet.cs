using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This script has been developed with the help of ChatGPT

public class Bullet : MonoBehaviour
{

    public float bulletLifetime = 0.8f;
    private GameObject player; // Reference to the player GameObject

    void Start()
    {
        // Destroy the bullet GameObject after a specified lifetime
        Destroy(gameObject,bulletLifetime);

        // Ignore collisions between the bullet and the player's collider
        if (player != null)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Destroy the bullet when it collides with an enemy
            Destroy(gameObject);
        }
        else
        {
            // Destroy the bullet when it collides with any other object
            Destroy(gameObject);
        }
    }

    // Method to set the player reference
    public void SetPlayer(GameObject playerObject)
    {
        player = playerObject;
    }
}
