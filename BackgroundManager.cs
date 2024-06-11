using System.Collections;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public Sprite[] backgrounds;
   
    void Start()
    {

        ChangeBackground();
    }

    public void ChangeBackground()
    {

        Sprite selectedBackground = backgrounds[Random.Range(0, backgrounds.Length)];


        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer != null)
        {

            spriteRenderer.sprite = selectedBackground;
        }
        else
        {
            Debug.LogError("SpriteRenderer component not found on the background GameObject.");
        }
    }
}
