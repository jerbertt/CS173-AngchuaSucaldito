using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_SisigBox : MonoBehaviour
{
    public Transform sisigObj;

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
        GameFlow.placeSisigPlate == "n" &&
        GameFlow.placeSisigPan == "n" &&
        GameFlow.placeEggPlate == "n" && 
        GameFlow.placeBurgerPan == "n" &&
        GameFlow.placeBurgerPlate == "n"&& 
        GameFlow.placeEggPlate == "n" && 
        GameFlow.placePlate == "y" &&
        GameFlow.burgersilogOnHand == "n")
        {
            //bool for if theres an Egg
            GameFlow.placeSisigPan = "y";

            Instantiate(sisigObj, new UnityEngine.Vector3(-0.104000002f,1.381f,-2.16578627f), sisigObj.rotation)
            .localScale = new UnityEngine.Vector3(15.0799999f,15.0799999f,15.0799999f);
        }
    }
}
