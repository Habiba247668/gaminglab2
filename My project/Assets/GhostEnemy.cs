using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemy : EnemyController
{
    private float flickerTime = 0f;
    private float flcikerDuration = 2f;

    void Start()
    {
        sr= GetComponent <SpriteRenderer>();
        sr.flipX= true;
        SprtieFlicker();
    }

    void SprtieFlicker(){
        if(flickerTime < flcikerDuration){
            flickerTime = flickerTime + Time.deltaTime;
        }
        else if (flickerTime >= flcikerDuration){
            sr.enabled =!(sr.enabled);
            flickerTime = 0;
        }
    }

    void FixedUpdate ()
    {
        if (sr.flipX == true){
            this.GetComponent<Rigidbody2D>().velocity = 
                new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        else {
            this.GetComponent<Rigidbody2D>().velocity = 
                new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            FindObjectOfType<PlayerStats>().TakeDamage(damage);
            Flip();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
