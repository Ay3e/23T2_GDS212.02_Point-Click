using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zooms : MonoBehaviour
{
    [SerializeField] private Animator fingerprintEvidence;
    private bool isActivate = false; 
    public void MaxFingerprintCardButton()
    {
        if (isActivate == false)
        {
            fingerprintEvidence.SetBool("isFingerprintEvidenceClicked", true);
            isActivate = true;
        }
        else
        {
            fingerprintEvidence.SetBool("isFingerprintEvidenceClicked", false);
            isActivate = false;
        }
    }
}
