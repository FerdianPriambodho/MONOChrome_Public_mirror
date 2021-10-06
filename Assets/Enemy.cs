using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;

    public Animator animator;
    //public GameObject deathEffect;
    void Start()
    {
        currentHealth = maxHealth;    
    }

    public void TakeDammage(int dammage)
    {
        currentHealth -= dammage;

        animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy dead!");

        animator.SetBool("isDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

        //to further animate death
        /*Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);*/
    }
}
