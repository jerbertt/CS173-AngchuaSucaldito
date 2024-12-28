using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan_Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (GameFlow.placePlate == "y" && GameFlow.placeSisigPan == "n" && GameFlow.placeBurgerPan == "n" && GameFlow.placeEggPan == "n")
        {
            Debug.Log("Click");
            
            if (GameFlow.placeBurgerPlate == "y") GameFlow.destroyBurger = "y";
            if (GameFlow.placeSisigPlate == "y") GameFlow.destroySisig = "y";
            if (GameFlow.placeEggPlate == "y") GameFlow.destroyEgg = "y";
            if (GameFlow.placeRicePlate == "y") GameFlow.destroyRice = "y";
            if (GameFlow.sisigsilogOnHand == "y") GameFlow.destroySisigSilog = "y";
            if (GameFlow.burgersilogOnHand == "y") GameFlow.destroyBurgerSilog = "y";

            //GameFlow.destroyPlate = "y";
            //GameFlow.destroySteam = "y";
            //if (GameFlow.burgersilogOnHand == "y") GameFlow.destroyBurgerSilog = "y";
            //if (GameFlow.sisigsilogOnHand == "y") GameFlow.destroySisigSilog = "y";
        
            GameFlow.placeEggPan = "n";
            GameFlow.placeSisigPan = "n";
            GameFlow.placeBurgerPan = "n";
            GameFlow.placeEggPlate = "n";
            GameFlow.placeBurgerPlate = "n";
            GameFlow.placeSisigPlate = "n";
            GameFlow.placeRicePlate = "n";
            GameFlow.sisigsilogOnHand = "n";
            GameFlow.burgersilogOnHand = "n";
            //GameFlow.placePlate = "y";
            //GameFlow.sisigsilogOnHand = "n";
            //GameFlow.burgersilogOnHand = "n";

            GameFlow.placeEggPan = "n";
            GameFlow.placeSisigPan = "n";
            GameFlow.placeBurgerPan = "n";
        }
    }
}
