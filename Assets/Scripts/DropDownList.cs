using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDownList : MonoBehaviour
{
    [SerializeField] private GameObject suspectPanel;
    private bool isActive;

    public void openSuspectPanelButton()
    {
        if(isActive == false)
        {
            suspectPanel.SetActive(true);
            isActive = true;
        }
        else
        {
            suspectPanel.SetActive(false);
            isActive = false;
        }
    }
}
