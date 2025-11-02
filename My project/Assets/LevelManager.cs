using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject CurrentCheckpoint;
    public Transform player;
    void Start()
    {
        CurrentCheckpoint= null;
        
    }

    
    void Update()
    {
        
    }

    public void RespawnPlayer(){
        FindObjectOfType <PlayerControl> ().transform.position = CurrentCheckpoint.transform.position;
    }


}
