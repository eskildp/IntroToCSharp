using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    public float LaserDistance;

    public LayerMask LayersToHit;

    // Update is called once per frame
    void Update()
    {
        //Defines a local RaycastHit2D variable that stores the information of the raycast that is run
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, LaserDistance, LayersToHit);
        //transform.position is used as the origin (where the raycast shoots out from)
        //transform.up is the direction the raycast shoots in
        //LaserDistance (defined at the top) is used as the distance the raycast should travel before it stops
        //LayersToHit is a LayerMask with information of what Layer(s) the raycast should hit


        //Debugs / prints the position of where the raycast hit a collider (if it doesn't hit anything hit.point defaults to 0,0,0)
        Debug.Log(hit.point);

        // if the raycast hits something ...
        if(hit.collider != null)
        {
            // ... this draws a green line between this transform.position and position of the hit
            Debug.DrawLine(transform.position, hit.point, Color.green);
        }
        else // if the raycast doesn't hit anything
        {
            // ... this draws a red ray out from this transform.position and in the direction of this transform.up with a length of LaserDistance
            Debug.DrawRay(transform.position, transform.up * LaserDistance, Color.red);
        }
    }
}
