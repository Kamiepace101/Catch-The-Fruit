using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private float _speed = 3f;
    
    // Strat is called before the first frame update
    void Start() 
    {
        
    }
    private void Update() 
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
        if (other.transform.tag == "Apple")
        {
            scoreKeeper.IncrementScore();
            Destroy(other.gameObject);
        }
        else
        {
        }
        if (transform.position.y < -6.67f)
        {
            Destroy(other.gameObject);
        }
    }
}
