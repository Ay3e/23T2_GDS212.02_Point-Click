using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayFingerprintCards : MonoBehaviour
{
    [SerializeField] private Animator maxFingerprintCardAnimator;
    private bool isActivate = false; 
    public void MaxFingerprintCardButton()
    {
        if (isActivate == false)
        {
            maxFingerprintCardAnimator.SetBool("isMaxFingerprintCardClicked", true);
            isActivate = true;
        }
        else
        {
            maxFingerprintCardAnimator.SetBool("isMaxFingerprintCardClicked", false);
            isActivate = false;
        }
    }
}
