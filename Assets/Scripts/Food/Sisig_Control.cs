using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sisig_Control : MonoBehaviour
{
    public Transform steamObj;
    public Material rawSisigMat;
    public Material cookedSisigMat;
    public float cookingTime;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(steamObj, steamObj.position, steamObj.rotation);
        GetComponent<MeshRenderer> ().material = rawSisigMat;
    }

    // Update is called once per frame
    void Update()
    {
        cookingTime += Time.deltaTime;

        if(cookingTime>GameFlow.timer)
        {
            GetComponent<MeshRenderer> ().material = cookedSisigMat;
        }

        if(GameFlow.destroySisig == "y" && gameObject)
        {
            GameFlow.destroySisig = "n";
            Destroy(gameObject);
        }
    }
    void OnMouseDown()
    {
        if(GameFlow.placeSisigPan == "y" && cookingTime >GameFlow.timer)
        {
            GetComponent<Transform> ().position = new Vector3(1.20799994f,1.25f,-2.01799989f);
            GameFlow.placeSisigPan = "n"; GameFlow.placeSisigPlate = "y"; GameFlow.destroySteam = "y";
        }
    }
}
