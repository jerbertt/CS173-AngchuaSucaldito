using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToCounter : MonoBehaviour
{
    public GameObject npcObj;
    public GameObject counterObj;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.spawnNew == "y")
        {
            GameFlow.spawnNew = "n";
            Instantiate (npcObj);
        }

        if (GameFlow.atCounter == "n")
        {
            npcObj.transform.position = Vector3.MoveTowards
            (npcObj.transform.position, counterObj.transform.position, speed);
        }

        if (npcObj.transform.position == counterObj.transform.position)
        {
            GameFlow.atCounter = "y";
        }
    }
}