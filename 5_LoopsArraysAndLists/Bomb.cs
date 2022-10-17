using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public KeyCode ExplodeButton;

    public CircleCollider2D ExplosionArea;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(ExplodeButton))
        {
            Explode();
        }
    }

    void Explode()
    {
        //Gets an array of all colliders inside explosion area radius
        Collider2D[] collidersInsideRadius = Physics2D.OverlapCircleAll(transform.position, ExplosionArea.radius);

        //Destroys every collider(object) inside radius (including itself)
        foreach(Collider2D collider in collidersInsideRadius)
        {
            Destroy(collider.gameObject);
        }
    }
}
