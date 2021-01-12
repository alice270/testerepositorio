using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedbyCollision : MonoBehaviour
{
    int health = 1;
    void OnTriggerEnter2D()
    {
        Debug.Log("oi");
        health--;
        
    }
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
     }
    void Die()
    {
        Destroy(gameObject);
 
    }
}
