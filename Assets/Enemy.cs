using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player.onEnemyHit += Damage;
    }

    void Damage(Color color)
    {
        transform.GetComponent<Renderer>().material.color = color;
    }

 // we need this because otherwise we'll get an error saying
 // that we are trying to access Enemy but it has been destroyed. 
    void OnDisable() // called automatically when an object is destroyed. 

    {
        Player.onEnemyHit -= Damage; // this is how we unsubscribe and avoid the console error. 
    }
}
