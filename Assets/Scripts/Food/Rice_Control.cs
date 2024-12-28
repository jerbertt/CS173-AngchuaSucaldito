using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rice_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.destroyRice == "y" && gameObject)
        {
            GameFlow.destroyRice = "n";
            Destroy(gameObject);
        }
    }
}
