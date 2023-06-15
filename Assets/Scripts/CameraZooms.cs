using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//booleans: isZoomedWitness, isZoomedCriminalRecord
public class CameraZooms : MonoBehaviour
{
    [SerializeField] private Animator cameraAnimator;
    private bool isActivate = false;
    private bool isActivated = false;

    public void WitnessStatementDocumentButton()
    {
        if (isActivate == false)
        {
            cameraAnimator.SetBool("isZoomedWitness", true);
            isActivate = true;
        }
        else
        {
            cameraAnimator.SetBool("isZoomedWitness", false);
            isActivate = false;
        }
    }

    public void CriminalRecordButton()
    {
        if (isActivated == false)
        {
            cameraAnimator.SetBool("isZoomedCriminalRecord", true);
            isActivated = true;
        }
        else
        {
            cameraAnimator.SetBool("isZoomedCriminalRecord", false);
            isActivated = false;
        }
    }
}
