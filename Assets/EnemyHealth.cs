using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int ehealth;


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Bullet")
        {
            TakeDamage(3);
            Destroy(coll.gameObject);
        }


        if (coll.gameObject.tag == "Grenade")
        {
            TakeDamage(2);
            Destroy(coll.gameObject);
        }
    }


    public void TakeDamage (int damage)
    {
        Debug.Log(damage + " damage was taken");
        ehealth -= damage;

        if (ehealth <= 0)
        {
            Die();
        }
    }


    void Die()
    
    {
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }

}
