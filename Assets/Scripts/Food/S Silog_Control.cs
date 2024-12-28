using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSilog_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.destroySisigSilog == "y" && gameObject) 
        {
            GameFlow.destroySisigSilog = "n";
            Destroy(gameObject);
            GameFlow.sisigsilogOnHand = "n";
            /*
            GameFlow.burgersilogOnHand = "n";

            GameFlow.placeEggPan = "n";
            GameFlow.placeSisigPan = "n";
            GameFlow.placeBurgerPan = "n";

            GameFlow.placeEggPlate = "n";
            GameFlow.placeBurgerPlate = "n";
            GameFlow.placeSisigPlate = "n";
            GameFlow.placeRicePlate = "n";
            GameFlow.placePlate = "n";
            */
            GameFlow.destroySteam = "n";
        }
    }
}
