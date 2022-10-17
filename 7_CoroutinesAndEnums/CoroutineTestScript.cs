using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTestScript : MonoBehaviour
{
    public List<string> DialogueLines; //Defines public a List of strings that can be edited in the Inspector

    WaitForSeconds OneSecondDelay = new WaitForSeconds(1); //a WaitForSeconds can be predefined and reused like any other variable type

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayDialogue()); //Uses the StartCoroutine()-function to start the PlayDialogue coroutine
    }

    IEnumerator PlayDialogue()
    {
        //a foreach loop that prints every dialogue line in the list (with a delay using WaitForSeconds())
        foreach(string dialogueLine in DialogueLines)
        {
            Debug.Log(dialogueLine);
            yield return new WaitForSeconds(Random.Range(2f, 4f)); //Waits a random amount of time between 2 and 4 seconds (with decimals)
        }
    }

    //Countdown example
    IEnumerator Countdown()
    {
        Debug.Log(3);
        yield return OneSecondDelay;

        Debug.Log(2);
        yield return OneSecondDelay;

        Debug.Log(1);
        yield return OneSecondDelay;

        Debug.Log("Go!");
    }
}
