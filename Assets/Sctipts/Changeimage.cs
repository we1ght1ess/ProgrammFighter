using UnityEngine;
using UnityEngine.UI;

public class Changeimage : MonoBehaviour
{
    public Sprite newImage; 
    private Image buttonImage;
    private Sprite originalImage;

    private void Start()
    {
        buttonImage = GetComponent<Image>();
        originalImage = buttonImage.sprite;
    }

    public void ChangeImage()
    {
        if (buttonImage.sprite == originalImage)
        {
            buttonImage.sprite = newImage;
        }
        else
        {
            buttonImage.sprite = originalImage;
        }
    }
}

