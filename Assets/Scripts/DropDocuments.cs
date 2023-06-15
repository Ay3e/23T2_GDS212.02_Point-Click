using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDocuments : MonoBehaviour
{
    [SerializeField] private Animator maxFingerPrintCardAnimator;
    [SerializeField] private Animator maxCriminalRecordAnimator;
    [SerializeField] private Animator harpFingerPrintCardAnimator;
    [SerializeField] private Animator harpCriminalRecordAnimator;
    private bool documentsAreOccupied = false;
    private bool maxDocumentsOpened = false;
    private bool harpDocumentsOpened = false;

    public void DropMaxDocumentsButton()
    {
        if (documentsAreOccupied == false)
        {
            //drop down his fingerprint and criminal record down
            maxFingerPrintCardAnimator.SetBool("isMaxClicked", true);
            maxCriminalRecordAnimator.SetBool("isMaxClicked", true);
            maxDocumentsOpened = true;
            documentsAreOccupied = true;
        }
        else
        {
            //if documents are opened for the first time check if max is already opened, if it is do nothing else remove harp docs and place max docs
            
            if(maxDocumentsOpened == false)
            {
                harpFingerPrintCardAnimator.SetBool("isHarpClicked", false);
                harpCriminalRecordAnimator.SetBool("isHarpClicked", false);
                harpDocumentsOpened = false;

                maxFingerPrintCardAnimator.SetBool("isMaxClicked", true);
                maxCriminalRecordAnimator.SetBool("isMaxClicked", true);
                maxDocumentsOpened = true;
            }
        }
    }
    public void DropHarpDocumentsButton()
    {
        if (documentsAreOccupied == false)
        {
            harpFingerPrintCardAnimator.SetBool("isHarpClicked", true);
            harpCriminalRecordAnimator.SetBool("isHarpClicked", true);
            documentsAreOccupied = true;
        }
        else
        {
            if(harpDocumentsOpened == false)
            {
                maxFingerPrintCardAnimator.SetBool("isMaxClicked", false);
                maxCriminalRecordAnimator.SetBool("isMaxClicked", false);
                maxDocumentsOpened = false;

                harpFingerPrintCardAnimator.SetBool("isHarpClicked", true);
                harpCriminalRecordAnimator.SetBool("isHarpClicked", true);
                harpDocumentsOpened = true;
            }
        }
    }
}
