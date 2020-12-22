using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinComponent : MonoBehaviour
{
    // variable if the message is printed or not
    private bool printedMessage;

    // variable for Transform object
    private Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from Start");
        myTransform = GetComponent<Transform>();
        Debug.Log(myTransform.position);
    }

    // Update is called once per frame
    void Update()
    {

        // rotates Transform object 
        myTransform.Rotate(0.1f,0f,0f);
        

        if (!printedMessage) 
        {
            Debug.Log("Hello from Update");
            printedMessage = true;
        }  
    }
}
