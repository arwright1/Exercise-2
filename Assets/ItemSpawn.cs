using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    //GameObject, we will get its x-position to calculate max x-position from spawned item
    public GameObject RightSide;

    //array with gameobjects, which will be spawned
    public GameObject[] items;

    //float variables: start delay befor first spawn, repeat delay between spawns
    public float startDelay, repeatRate;

    // Start is called before the first frame update
    void Start()
    {
        //start spawn function
        InvokeRepeating("Spawn", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Spawn()
    {
        //calculate random position, x is random between Spawn and RightSide
        Vector3 pos = new Vector3(Random.Range(gameObject.transform.position.x, RightSide.transform.position.x), gameObject.transform.position.y, 0);

        //place random gameobject from array into calculated position
        Instantiate(items[Random.Range(0, items.Length)], pos, gameObject.transform.rotation);
    }
}
