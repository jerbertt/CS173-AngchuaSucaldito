using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate_Control : MonoBehaviour
{
    public Transform burgersilogObj;
    public Transform sisigSilogObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {

        if (GameFlow.placeEggPlate == "y" &&
        GameFlow.placeBurgerPlate == "y" &&
        GameFlow.placeRicePlate == "y" &&
        GameFlow.placePlate == "y")
        {
            //Debug.Log("Clicked!");

            GameFlow.destroySteam = "y";
            GameFlow.destroyBurger = "y";
            GameFlow.destroyRice = "y";
            GameFlow.destroyEgg = "y";
            Destroy(gameObject); // destroyPlate = "y"

            GameFlow.burgersilogOnHand= "y";

            GameFlow.placeEggPlate = "n";
            GameFlow.placeBurgerPlate = "n"; 
            GameFlow.placeRicePlate = "n"; 
            GameFlow.placePlate = "n";

            Instantiate(burgersilogObj, new Vector3(1.535f, 1.416f, -1.919f), burgersilogObj.rotation)
            .localScale = new Vector3(0.65f, 0.65f, 0.65f);
        } 

        if (GameFlow.placeEggPlate == "y" &&
        GameFlow.placeSisigPlate == "y" &&
        GameFlow.placeRicePlate == "y" &&
        GameFlow.placePlate == "y")
        {
            //Debug.Log("Clicked!");

            GameFlow.destroySteam = "y";
            GameFlow.destroySisig = "y";
            GameFlow.destroyRice = "y";
            GameFlow.destroyEgg = "y";
            Destroy(gameObject); // destroyPlate = "y"

            GameFlow.sisigsilogOnHand= "y";

            GameFlow.placeEggPlate = "n";
            GameFlow.placeSisigPlate = "n"; 
            GameFlow.placeRicePlate = "n"; 
            GameFlow.placePlate = "n";

            Instantiate(sisigSilogObj, new Vector3(1.535f, 1.416f, -1.919f), sisigSilogObj.rotation)
            .localScale = new Vector3(0.65f, 0.65f, 0.65f);
        } 
    }
}
