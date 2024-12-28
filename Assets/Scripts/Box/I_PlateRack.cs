using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_PlateRack : MonoBehaviour
{
    public Transform plateObj;
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
        if (GameFlow.placePlate == "n" &&
        GameFlow.burgersilogOnHand == "n" &&
        GameFlow.sisigsilogOnHand == "n")
        {
            GameFlow.placePlate = "y";

            Instantiate(plateObj, new Vector3(1.103f, 1.175f, -1.982f), plateObj.rotation)
            .localScale = new Vector3(0.65f, 0.65f, 0.65f);
        }
    }
}
