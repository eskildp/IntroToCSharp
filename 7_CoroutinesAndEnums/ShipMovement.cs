using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float MovementSpeed;

    public CompassDirection currentDirection;

    void Update()
    {
        //Checks input and sets current compass direction according to arrow direction
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentDirection = CompassDirection.North;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentDirection = CompassDirection.West;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentDirection = CompassDirection.South;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentDirection = CompassDirection.East;
        }

        //Sets rotation according to current compass direction
        transform.rotation = Quaternion.Euler(0, 0, (int)currentDirection);

        //Runs the Move-function
        Move();
        //Because it is in Update (and not restrained by any if statement/condition) it will run every frame which makes automatic movement
    }

    void Move()
    {
        //A switch statement which checks current direction and moves the transform along that direction

        switch (currentDirection)
        {
            case CompassDirection.North:
                transform.position += Vector3.up * Time.deltaTime * MovementSpeed;
                break;
            case CompassDirection.West:
                transform.position += Vector3.left * Time.deltaTime * MovementSpeed;
                break;
            case CompassDirection.South:
                transform.position += Vector3.down * Time.deltaTime * MovementSpeed;
                break;
            case CompassDirection.East:
                transform.position += Vector3.right * Time.deltaTime * MovementSpeed;
                break;
            default:
                break;
        }
    }
}
