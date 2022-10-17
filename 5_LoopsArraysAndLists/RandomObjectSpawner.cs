using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    public KeyCode SpawnButton;

    public List<GameObject> Objects;

    void Update()
    {
        if(Input.GetKeyDown(SpawnButton))
        {
            SpawnRandomObject();
        }
    }

    void SpawnRandomObject()
    {
        int randomIndex = Random.Range(0, Objects.Count);
        Instantiate(Objects[randomIndex]);
    }
}
