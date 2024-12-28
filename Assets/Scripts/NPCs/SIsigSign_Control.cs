using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIsigSign_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.destroySisigSign == "y")
        {
            GameFlow.destroySisigSign = "n";
            GameFlow.sisigSign = "n";
            Destroy(gameObject);
        }
    }
}
