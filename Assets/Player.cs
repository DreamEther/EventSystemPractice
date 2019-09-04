using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Singletons allow us to create an instance of this class at any time during runtime.
    //The script doesn't even have to be attached to a GameObject in a scene. 
    #region Singleton
    private static Player _instance; // using static keyword so we can say Player._instance in another class without having to find the object/s with this script
    public static Player Instance
    {
        get
        {
            if (_instance == null) // if instance does not exist
            {
                GameObject gameObject = new GameObject("Player"); // creates a new object in our scene named Player
                gameObject.AddComponent<Player>(); // grabbing the created object and adding this class as a component
            }

            return _instance; //otherwise return this instance. 
        }
    }
    #endregion

    public int Health {get; set;} // now we can access all public fields by 'Player.Instance.health' for example.  
    public int attackPower;
 
    void Awake()
    {
        _instance = this;
    }
    public delegate void ChangeEnemyColor(Color color);

    public static event ChangeEnemyColor onEnemyHit; // events have to be static


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (onEnemyHit != null)
            {
               onEnemyHit(Color.red);
            }
        } 
    }
}
