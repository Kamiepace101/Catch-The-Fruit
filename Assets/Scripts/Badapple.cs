﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badapple : MonoBehaviour
{
    private float _speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
        if (other.transform.tag == "Badapple")
        {
            Destroy(other.gameObject);
        }
        if (transform.position.y >= -6.67f)
        {
            return;
        }
        Destroy(other.gameObject);
    }

    public void KillPlayer(GrandmaController player)
    {
        Destroy (player.gameObject);
    }
}
