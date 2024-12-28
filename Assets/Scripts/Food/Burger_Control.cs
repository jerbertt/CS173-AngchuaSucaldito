using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class Burger_Control : MonoBehaviour
{
    public Material cookedBurgerMat;
    public Material rawBurgerMat;
    public Transform steamObj;
    public float cookingTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (GameFlow.placeBurgerPan == "y")
        {
            Instantiate(steamObj, steamObj.position, steamObj.rotation);
            GetComponent<MeshRenderer> ().material = rawBurgerMat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        cookingTime += Time.deltaTime;

        if(cookingTime>GameFlow.timer)
        {
            GetComponent<MeshRenderer> ().material = cookedBurgerMat;
        }

        if(GameFlow.destroyBurger == "y" && gameObject)
        {
            GameFlow.destroyBurger = "n";
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        if(GameFlow.placeBurgerPan == "y" && cookingTime > GameFlow.timer)
        {
            GetComponent<Transform> ().position = new Vector3 (1.227f, 1.23f,  -2.035f);
            GameFlow.placeBurgerPan = "n"; GameFlow.placeBurgerPlate = "y"; GameFlow.destroySteam = "y";
        }
    }
}
