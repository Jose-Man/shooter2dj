using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will replace the cursor with a new texture you provide when the game starts
/// </summary>
public class CursorChanger : MonoBehaviour
{
    [Header("Settings:")]
    [Tooltip("The cursor to change to")]
    public Texture2D[] newCursorSprite;

    private float frameTimer;
    public float frameRate;
    private int currentFrame;
        
    /// <summary>
    /// Description:
    /// Standard Unity function called once when the script is first loaded and before Update is called
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    void Start()
    {
        ChangeCursor(0);
    }

    private void Update()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0f) 
        {
            frameTimer += frameRate;
            //currentFrame = (currentFrame + 1) % frameCount;
            currentFrame = (currentFrame + 1) % newCursorSprite.Length;
            ChangeCursor(currentFrame);
        }
    }

    /// <summary>
    /// Description:
    /// Changes the cursor to the one set in the inspector
    /// Inputs:
    /// None
    /// Returns:
    /// void (no return)
    /// </summary>
    void ChangeCursor(int frame)
    {
        Cursor.lockState = CursorLockMode.Confined;

        // The location that clicking actually hits, also positions the clicker
        Vector2 hotSpot = new Vector2();
        // Dividing the width and height by 2 will center it
        hotSpot.x = newCursorSprite[frame].width / 2;
        hotSpot.y = newCursorSprite[frame].height / 2;

        Cursor.SetCursor(newCursorSprite[frame], hotSpot, CursorMode.Auto);
    }

}
