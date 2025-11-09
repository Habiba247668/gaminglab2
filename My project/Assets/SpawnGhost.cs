using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{
    public Transform enemy;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void RespawnEnemy(){
        Instantiate(enemy, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Player"){
            RespawnEnemy();
        }
    }
}
