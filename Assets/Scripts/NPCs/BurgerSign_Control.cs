using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerSign_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.destroyBurgerSign == "y")
        {
            GameFlow.destroyBurgerSign = "n";
            GameFlow.burgerSign = "n";
            Destroy(gameObject);
        }
    }
}
