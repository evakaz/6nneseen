using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject player;
    public GameObject Pyss;
    public GameObject Pudel;

    private bool weaponHit = false;
    //private bool isAttached;
    public bool pickUphasBeenCalled;
    public Player playerScript;


    void Start()
    {
        player = GameObject.Find("Player");
        GameObject Pudel = GameObject.FindGameObjectWithTag("Meele");
        GameObject Pyss = GameObject.FindGameObjectWithTag("Weapon");
    }
    void Update()
    {
        if (weaponHit && Input.GetKeyDown(KeyCode.E) & !playerScript.weaponIsAttached)
        {
            PickUp();
        }


        if (Input.GetKeyDown("q") && playerScript.weaponIsAttached)
        {
            DropWeapon();
        }
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            weaponHit = true;
        }

    }


    void PickUp()
    {
        transform.SetParent(player.transform);
        if(gameObject == Pudel)
        {
            transform.localPosition = new Vector3(0.9f, 0.6f);
        }
        else
        {
            transform.localPosition = new Vector3(0.7f, 0.15f);
        }
        pickUphasBeenCalled = true;
        Debug.Log("eskere");
    }


    void DropWeapon()
    {
        transform.parent = null;
        pickUphasBeenCalled = false;

        if(gameObject == Pudel)
        {
            Destroy(Pudel);
        }

        else
        {
            Destroy(Pyss);    
        }
        
        //set parent to null and set the new weapon as a child
    }
}