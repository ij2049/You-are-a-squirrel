﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private GameMaster gm;

    // Start is called before the first frame update
    void Start()
    {
        
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        
    }
private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
            gm.lastCheckPointPos = transform.position;
        }   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
