using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int DiceRoll; //An int variable to store the value of the dice roll in

    // Update is called once per frame
    void Update()
    {
        // Input check. GetKeyDown() returns true only the first frame given key (in this case: Space) is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DiceRoll = RollDice(); //Uses the RollDice() function (which is defined further down) to assign a number to DiceRoll
        }
    }

    int RollDice()
    {
        int eyesAmount = Random.Range(1, 7); //Gets a random int from 1 to 6 and assigns it to local parameter "eyesAmount"
        print(eyesAmount); //Prints eyesAmount to the Console
        return eyesAmount; //Returns the number to wherever the RollDice-function is called
    }
}
