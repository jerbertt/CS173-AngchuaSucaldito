using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_Control : MonoBehaviour
{
    public Transform steamObj;
    public Material rawEggMat;
    public Material cookedEggMat;
    public float cookingTime;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(steamObj, steamObj.position, steamObj.rotation);
        GetComponent<MeshRenderer> ().material = rawEggMat;
    }

    // Update is called once per frame
    void Update()
    {
        cookingTime += Time.deltaTime;

        if(cookingTime>GameFlow.timer)
        {
            GetComponent<MeshRenderer> ().material = cookedEggMat;
        }

        if(GameFlow.destroyEgg == "y" && gameObject)
        {
            GameFlow.destroyEgg = "n";
            Destroy(gameObject);
        }
    }
    void OnMouseDown()
    {
        if(GameFlow.placeEggPan == "y" && cookingTime >GameFlow.timer)
        {
            GetComponent<Transform> ().position = new Vector3 (0.982f, 1.255f,  -2.027f);
            GameFlow.placeEggPan = "n"; GameFlow.placeEggPlate = "y"; GameFlow.destroySteam = "y";
        }
    }
}
