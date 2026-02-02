using System.Collections.Generic;
using UnityEngine.InputSystem; 
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer  spriteRenderer; 
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //PickARandomColour(); 
        //spriteRenderer.sprite = mySprite; 
        PickARandomSprite(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            PickARandomSprite(); 
        }

        if(Mouse.current.leftButton.wasPressedThisFrame && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }

        // get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()); 

        //is the mouse position over this sprite? 
        if(spriteRenderer.sprite.bounds.Contains(mousePos) == true)
        {
            //Y: set the colour to our col variable 
            spriteRenderer.color = col;
        }
        else
        {
            spriteRenderer.color = Color.white; 
        }

    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV(); 
    }

    void PickARandomSprite()
    {

    }
}
