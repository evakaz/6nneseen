using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public Rigidbody2D rb;
	public float speed = 20f;


	void Start () 
	{
		if (gameObject.tag == "Bullet")
		{
			rb.velocity = transform.right * speed;
		}
		if (gameObject.tag == "RohelineKuul")
		{
			rb.velocity = -transform.right * speed;
		}
	}

	void OnBecameInvisible()
	{
		Destroy(gameObject);
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag != "Player" | coll.gameObject.tag != "Background")
		{
			Destroy(gameObject);
		}
	}
}