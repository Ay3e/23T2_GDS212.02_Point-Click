using UnityEngine;
using UnityEngine.UI;

public class ImageArrayButton : MonoBehaviour
{
    public Image[] imageArray;
    private int currentIndex = 0;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeImage);
    }

    private void ChangeImage()
    {
        if (currentIndex < imageArray.Length - 1)
        {
            currentIndex++;
        }
        else
        {
            currentIndex = 0;
        }

        Image targetImage = GetComponent<Image>();
        targetImage.sprite = imageArray[currentIndex].sprite;
    }
}
