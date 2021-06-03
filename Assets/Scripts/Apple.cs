using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private float _speed = 3f;
    
    // Strat is called before the first frame update
    void Start() {
        
    }
    private void Update() 
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.transform.tag =="Apple"){
            Destroy(other.gameObject);
        }
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if(transform.position.y < -6.67f)
        {
            Destroy(other.gameObject);
        }
    }
    
    private void FallingApples()
    {
        ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
        if(scoreKeeper != null)
        {
            scoreKeeper.IncrementScore();
        }
        Destroy(gameObject);
    }
}
