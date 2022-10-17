using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    //Defines an array of ints with 5 empty values
    int[] numbers = new int[5];

    public GameObject[] gameObjects;

    void Start()
    {
        //Assigns a value of 2 to the element in the numbers array with an index of 1 (the 2nd element)
        numbers[1] = 2;

        //Assigns a value of -10 to the element in the numbers array with an index of 3 (the 4th element)
        numbers[3] = -10;

        ArrayExample1(); //Runs the function containing the first array example
    }

    void ArrayExample1()
    {
        //prints the values of all the elements in the numbers array
        for (int i = 0; i < numbers.Length; i++)
        {
            print(numbers[i]);
        }
    }

    void ArrayExample2()
    {
        //prints the names of all GameObjects in the gameObject array
        for (int i = 0; i < gameObjects.Length; i++)
        {
            print(gameObjects[i].name);
        }
    }
}
