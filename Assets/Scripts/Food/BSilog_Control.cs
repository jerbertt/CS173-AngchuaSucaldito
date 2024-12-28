using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BSilog_Control : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.destroyBurgerSilog == "y" && gameObject) 
        {
            GameFlow.destroyBurgerSilog = "n";
            Destroy(gameObject);
            GameFlow.burgersilogOnHand = "n";
            GameFlow.destroySteam = "n";
        }
    }
}
