using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public int Number;

    bool hasPrinted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Increments (adds 1 to) the Number variable's value every fram
        Number++;

        //Checks if Number has reached over 9000 AND that hasPrinted isn't true
        if (Number > 9000 && hasPrinted != true)
        {
            print("IT'S OVER 9000"); //prints given string to the console
            hasPrinted = true; //sets hasPrinted to true so that the if statement won't return true (until hasPrinted is set to false)
        }
    }
}
