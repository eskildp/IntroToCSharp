using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    //Defines an empty list of strings
    public List<string> names = new List<string>();

    void Start()
    {
        //Adds values to the list
        names.Add("Serkan");
        names.Add("André");
        names.Add("Erkan");
        names.Add("Jonas");
        names.Add("Morgan");

        //for loop that prints all the names in the list
        for (int i = 0; i < names.Count; i++)
        {
            print(names[i]);
        }

        //removes the name with the index of 4 and then the name with the index of 2
        names.RemoveAt(4);
        names.RemoveAt(2);
    }
}
