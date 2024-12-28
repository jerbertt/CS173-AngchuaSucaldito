using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_BurgerBox : MonoBehaviour
{
    public Transform rawBurgerObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (GameFlow.placeEggPan == "n" && 
        GameFlow.placeBurgerPlate == "n" && 
        GameFlow.placeBurgerPan == "n" && 
        GameFlow.placeBurgerPlate == "n" && 
        GameFlow.placeSisigPan == "n" &&
        GameFlow.placePlate == "y" &&
        GameFlow.placeSisigPlate == "n" &&
        GameFlow.burgersilogOnHand == "n")
        {
            //bool for if theres an Egg
            GameFlow.placeBurgerPan = "y";

            //place burger on frying pan
            Instantiate(rawBurgerObj, new Vector3(-0.09799993f, 1.379f, -2.152f), rawBurgerObj.rotation)
            .localScale = new Vector3(1.78f, 1.78f, 1.78f);
        }
    }
}
