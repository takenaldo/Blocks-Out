using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtraLangCheck : MonoBehaviour
{
    /*
        This component created for tracking language changes for several objects which can't track the localization for some reason for 
           sprite changes.

        Note: extra means this file too much project specific

     */

    public int current_language = GameManager.LANGUAGE_EN;


    public Sprite spriteON_en, spriteOFF_en;
    public Sprite spriteON_ru, spriteOFF_ru;


    // Start is called before the first frame update
    void Start()
    {
        current_language = Helper.getPreferedLanguage();
                
    }

    // Update is called once per frame
    void Update()
    {
        if(current_language != Helper.getPreferedLanguage())
        {

            changeSprite();
            current_language = Helper.getPreferedLanguage();

        }

    }

    private void changeSprite()
    {
        Image image = gameObject.GetComponent<Image>();
        if (image.sprite == spriteON_en || image.sprite == spriteON_ru)
            image.sprite = getSpriteON();
        else
            image.sprite = getSpriteOFF();

    }

    private Sprite getSpriteOFF()
    {
        if (Helper.getPreferedLanguage() == GameManager.LANGUAGE_EN)
            return spriteOFF_en;
        else if (Helper.getPreferedLanguage() == GameManager.LANGUAGE_RU)
            return spriteOFF_ru;

        return spriteOFF_en;
    }


    private Sprite getSpriteON()
    {
        if (Helper.getPreferedLanguage() == GameManager.LANGUAGE_EN)
            return spriteON_en;
        else if (Helper.getPreferedLanguage() == GameManager.LANGUAGE_RU)
            return spriteON_ru;

        return spriteON_en;
    }
}
