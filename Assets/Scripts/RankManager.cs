using UnityEngine;

public class RankManager : MonoBehaviour
{
    [SerializeField] private GameObject rankPanel;
    [SerializeField] private GameObject[] barLevelUnlocked;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip win;
    [SerializeField] private AudioClip lose;
    [SerializeField] private AudioClip button;
    private int roundCounter=0;

    public void MaxPerpetratorButton()
    {
        rankPanel.SetActive(true);
        audioSource.PlayOneShot(win);
        roundCounter++;
        for(int i=0; i<roundCounter; i++) 
        {
            barLevelUnlocked[i].SetActive(true);
        }
    }

    public void HarpPerpetratorButton()
    {
        if(roundCounter>barLevelUnlocked.Length)
        {
            roundCounter = barLevelUnlocked.Length;
        }
        for (int i = 0; i < roundCounter; i++)
        {
            barLevelUnlocked[i].SetActive(false);
        }
        if (roundCounter > 0)
        {
            roundCounter--;
            for (int i = 0; i < roundCounter; i++)
            {
                barLevelUnlocked[i].SetActive(true);
            }
        }
        audioSource.PlayOneShot(lose);
        rankPanel.SetActive(true);
    }

    public void ContinueButton()
    {
        audioSource.PlayOneShot(button);
        rankPanel.SetActive(false);
    }
}
