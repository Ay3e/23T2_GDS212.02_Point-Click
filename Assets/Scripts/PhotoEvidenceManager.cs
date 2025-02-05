using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoEvidenceManager : MonoBehaviour
{
    [SerializeField] private GameObject evidenceOne, evidenceTwo, evidenceThree;

    [SerializeField] private Animator fingerprintAnimator;
    [SerializeField] private Animator sceneAnimator;
    private bool isActivate = false;
    public void FingerprintPhotoButton()
    {
        if (isActivate == false)
        {
            fingerprintAnimator.SetBool("isFingerprintPhotoPressed", true);
            isActivate = true;
            //evidenceTwo.SetActive(false);
            evidenceThree.SetActive(false);
        }
        else
        {
            fingerprintAnimator.SetBool("isFingerprintPhotoPressed", false);
            isActivate = false;
            //evidenceTwo.SetActive(true);
            evidenceThree.SetActive(true);
        }
    }

    public void ScenePhotoButton()
    {
        if (isActivate == false)
        {
            sceneAnimator.SetBool("isScenePhotoPressed", true);
            isActivate = true;
            evidenceOne.SetActive(false);
            //evidenceTwo.SetActive(false);
        }
        else
        {
            sceneAnimator.SetBool("isScenePhotoPressed", false);
            isActivate = false;
            evidenceOne.SetActive(true);
            //evidenceTwo.SetActive(true);
        }
    }
}
