using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // need to use delegates.

public class CallbackSystem : MonoBehaviour
{
    public delegate void OnMessageReceived(); 
    // we can assign this delegate to any function that has the same signature. In this case it is void 
    

    void Start()
    {  
        OnMessageReceived test = WriteMessage;
        test();
    }


    void Update()
    {
        
    }

    void WriteMessage()
    {
        Debug.Log("WriteMessage() Called");
    }
}
