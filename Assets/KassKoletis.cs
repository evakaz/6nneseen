using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KassKoletis : MonoBehaviour
{

    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 whereToMove;
    public float moveSpeed = 0f;


    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }


    void Update(){
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        movement = direction;
        moveCharacter(movement);
    }


    void moveCharacter(Vector2 direction){
        whereToMove = (Vector2)transform.position + (direction * moveSpeed * Time.deltaTime);
        //Debug.Log(whereToMove);
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}

