using UnityEngine;

public class DropDownList : MonoBehaviour
{
    [SerializeField] private GameObject suspectPanel;
    private bool isActive;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip buttonPress;

    public void openSuspectPanelButton()
    {
        if(isActive == false)
        {
            suspectPanel.SetActive(true);
            isActive = true;
            audioSource.PlayOneShot(buttonPress);
        }
        else
        {
            suspectPanel.SetActive(false);
            isActive = false;
            audioSource.PlayOneShot(buttonPress);
        }
    }
}
