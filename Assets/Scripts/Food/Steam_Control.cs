using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steam_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameFlow.destroySteam == "y" && gameObject)
        {
            GameFlow.destroySteam = "n";
            Destroy(gameObject);
        }
    }
}
