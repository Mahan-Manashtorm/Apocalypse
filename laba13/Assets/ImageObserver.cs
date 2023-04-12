using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageObserver : MonoBehaviour
{
    public Image BG;
    


    private void OnEnable()
    {
        // Підписуємось на подію ImageAddedEvent
        ImageAddButton imageAddButton = FindObjectOfType<ImageAddButton>();
        imageAddButton.onImageAdded.AddListener(HandleImageAdded);
    }

    private void OnDisable()
    {
        // Відписуємось від події ImageAddedEvent
        ImageAddButton imageAddButton = FindObjectOfType<ImageAddButton>();
        imageAddButton.onImageAdded.RemoveListener(HandleImageAdded);
    }

    private void HandleImageAdded(Sprite newSprite)
    {
        // Виконуємо відповідні дії при отриманні нового зображення
        //GameObject obj = newSprite;
        //_sprites.Add(obj);

        if (newSprite.name == "tree")
        {
            BG.color = new Color32(121, 238, 144, 255);
        }
        else if (newSprite.name == "snow")
        {
            BG.color = new Color32(15, 67, 91, 255);
        }
        else if (newSprite.name == "sun")
        {
            BG.color = new Color32(247, 248, 158, 255);
        }
        else if (newSprite.name == "cloud")
        {
            BG.color = new Color32(135, 156, 168, 255);
        }

        // Код для відображення нового зображення на екрані
    }
}
