using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class I_RiceBox : MonoBehaviour
{
    public Transform riceObj;
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
        if(GameFlow.placeRicePlate == "n" && 
        GameFlow.placePlate == "y")
        {
            GameFlow.placeRicePlate = "y";
            Instantiate(riceObj, new Vector3(1.354f, 1.29f, -1.958f), riceObj.rotation)
            .localScale = new Vector3(0.08f, 0.08f, 0.08f);
        }
    }
}
