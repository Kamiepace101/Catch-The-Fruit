using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private float apple = 0;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.transform.tag =="Apple"){
            Destroy(other.gameObject);
        }
        
    }
}
