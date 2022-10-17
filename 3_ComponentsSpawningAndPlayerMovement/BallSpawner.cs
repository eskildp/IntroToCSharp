using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    //A public GameObject variable which let's us assign a reference to it in the Inspector
    public GameObject BallPrefab;
    //In class we used a Prefab of a Circle sprite with a Circle Collider and a Rigidbody2D attached to it

    // Update is called once per frame
    void Update()
    {
        //When Space is pressed...
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //... this spawns whatever is set as BallPrefab in the inspector at the spawners position and with it's original rotation
            Instantiate(BallPrefab, transform.position, BallPrefab.transform.rotation);
        }
    }
}
