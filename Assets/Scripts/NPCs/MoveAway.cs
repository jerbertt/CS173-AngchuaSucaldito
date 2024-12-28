using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAway : MonoBehaviour
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
        if(GameFlow.moveAway == "y")
        {
            npcObj.transform.position = Vector3.MoveTowards
            (npcObj.transform.position, counterObj.transform.position, speed);
        }

        if (npcObj.transform.position == counterObj.transform.position && GameFlow.atCounter == "y")
        {
            GameFlow.atCounter = "n";
            GameFlow.moveAway = "n";
            GameFlow.spawnNew = "y";
            Destroy(gameObject);
        }
    }
}