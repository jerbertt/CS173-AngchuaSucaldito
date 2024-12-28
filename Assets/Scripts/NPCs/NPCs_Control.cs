using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCs_Control : MonoBehaviour
{
    public static string order = "sisig";
    public Transform sisigOrderObj;
    public Transform burgerOrderObj;
    public Transform checkObj;
    public Transform xObj;

    public AudioSource correctSound;
    public AudioSource wrongSound;



    void Update()
    {
        if (order == "burger" && GameFlow.checkSign == "n" && GameFlow.xSign == "n" && GameFlow.burgerSign == "n" && GameFlow.sisigSign == "n"
        && GameFlow.atCounter == "y" && GameFlow.moveAway == "n")
        {
            GameFlow.burgerSign = "y";
            Instantiate(burgerOrderObj, new Vector3(1.91f,2.62f,-3.32f), burgerOrderObj.rotation);
        }

        if (order == "sisig" && GameFlow.checkSign == "n" && GameFlow.xSign == "n" && GameFlow.burgerSign == "n" && GameFlow.sisigSign == "n"
        && GameFlow.atCounter == "y" && GameFlow.moveAway == "n")
        {
            GameFlow.sisigSign = "y";
            Instantiate(sisigOrderObj, new Vector3(1.90f,2.63f,-3.45f), sisigOrderObj.rotation);
        }
    }

    void OnMouseDown()
    {

        if (order == "sisig")
        {
            if (GameFlow.sisigsilogOnHand == "y")
            {
                GameFlow.destroySisigSilog = "y";
                GameFlow.destroySisigSign = "y";

                AudioManager.Instance.Play(AudioManager.SoundType.Correct);
                GameFlow.moveAway = "y";
                Score_Control.AddPoint();
                order = "burger";
            } 

            else if (GameFlow.burgersilogOnHand == "y")
            {
                GameFlow.destroyBurgerSilog = "y";
                
                AudioManager.Instance.Play(AudioManager.SoundType.Wrong);
                Score_Control.MinusPoint();
            }
        }

        else if (order == "burger")
        {
            if (GameFlow.sisigsilogOnHand == "y")
            {
                GameFlow.destroySisigSilog = "y";
                
                AudioManager.Instance.Play(AudioManager.SoundType.Wrong);
                Score_Control.MinusPoint();
            } 
            else if (GameFlow.burgersilogOnHand == "y")
            {
                GameFlow.destroyBurgerSilog = "y";
                GameFlow.destroyBurgerSign = "y";  
                
                AudioManager.Instance.Play(AudioManager.SoundType.Correct);
                GameFlow.moveAway = "y";
                Score_Control.AddPoint();
                order = "sisig";
            }
        }
    }
}
