using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinComponent : MonoBehaviour
{
    private bool printedMessage;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (!printedMessage) 
        {
            Debug.Log("Hello from Update");
            printedMessage = true;
        }  
    }
}
