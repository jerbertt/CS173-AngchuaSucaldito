using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class I_EggBox : MonoBehaviour
{
    public Transform eggObj;

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
        //Spawns egg on the frying pan at a certain scale
        if (GameFlow.placeEggPan == "n" && 
        GameFlow.placeEggPlate == "n" && 
        GameFlow.placeBurgerPan == "n" && 
        GameFlow.placeEggPlate == "n" && 
        GameFlow.placeSisigPan == "n" &&
        GameFlow.placePlate == "y" &&
        GameFlow.burgersilogOnHand == "n")
        {
            //bool for if theres an Egg
            GameFlow.placeEggPan = "y";

            Instantiate(eggObj, new UnityEngine.Vector3(-0.09799993f, 1.379f, -2.152f), eggObj.rotation)
            .localScale = new UnityEngine.Vector3(1.78f, 1.78f, 1.78f);
        }
    }
}
