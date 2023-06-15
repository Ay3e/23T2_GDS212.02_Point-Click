using UnityEngine;
using TMPro;

public class ZoomsEvidence : MonoBehaviour
{
    [SerializeField] private Animator fingerprintEvidence;
    [SerializeField] private Animator crimeSceneEvidence;
    [SerializeField] private TextMeshProUGUI crimeType;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip fingerprintAudioClip;
    [SerializeField] private AudioClip fingerprintAudioClipTwo;
    private bool isActivate = false;
    private bool isActivated = false;
    public void FingerprintEvidence()
    {
        if (isActivate == false)
        {
            fingerprintEvidence.SetBool("isFingerprintEvidenceClicked", true);
            isActivate = true;
            audioSource.PlayOneShot(fingerprintAudioClip);
        }
        else
        {
            fingerprintEvidence.SetBool("isFingerprintEvidenceClicked", false);
            isActivate = false;
            audioSource.PlayOneShot(fingerprintAudioClipTwo);
        }
    }


    public void CrimeSceneEvidence()
    {
        if(isActivated == false)
        {
            crimeSceneEvidence.SetBool("isCrimeSceneEvidenceClicked", true);
            isActivated = true;
            crimeType.text = "CRIME TYPE: HOMICIDE";
            audioSource.PlayOneShot(fingerprintAudioClip);
        }
        else
        {
            crimeSceneEvidence.SetBool("isCrimeSceneEvidenceClicked", false);
            isActivated = false;
            audioSource.PlayOneShot(fingerprintAudioClipTwo);
        }
    }
}
