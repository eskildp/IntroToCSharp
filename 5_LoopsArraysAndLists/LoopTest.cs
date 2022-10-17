using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Example solution for the loop-assignment
        for (int i = 0; i < 20; i++)
        {
            switch(i)
            {
                case 2:
                    print(i);
                    break;
                case 5:
                    print(i);
                    break;
                case 14:
                    print(i);
                    break;
                case 19:
                    print(i);
                    break;
                default:
                    break;
            }
        }
    }

    void ForLoopExample()
    {
        //for loop that prints all whole numbers from 10 to 20
        for (int i = 10; i < 21; i++)
        {
            print(i);
        }
    }

    void WhileLoopExample()
    {
        //while loop that prints all whole numbers from 1 to 1000

        int i = 0;
        while (i < 1000)
        {
            print(i);
            i++;
        }
    }
}
