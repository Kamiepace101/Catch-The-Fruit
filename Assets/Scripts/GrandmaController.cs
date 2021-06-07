using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandmaController : MonoBehaviour
{
    // Start is called before the first frame update
    public class PlayerStats 
    {
        public int Health = 100;
    }
    public PlayerStats playerStats = new PlayerStats();

public void DamagePlayer (int damage) 
{
    playerStats.Health -= damage;
    if (playerStats.Health <= 0)
    {
        Debug.Log ("KILL PLAYER");
    }
}

    public float MovementSpeed = 1;


    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}
