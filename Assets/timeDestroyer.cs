using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeDestroyer : MonoBehaviour
{
    //how long gameObject will stay in the scene
    public float aliveTimer;

    // Start is called before the first frame update
    void Start()
    {
        //destroy function deletes gameobjetc from scene after a certain amount of time
        Destroy(gameObject, aliveTimer);
    }

}
