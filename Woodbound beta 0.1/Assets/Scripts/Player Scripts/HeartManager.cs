﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour {

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite halfFullHeart;
    public Sprite emptyHeart;
    public FloatValue heartContainers;
    public FloatValue playerCurrentHealth;

	// Use this for initialization
	void Start () {
        //InitHearts();
        UpdateHearts();
	}

    public void InitHearts()
    {
        for (int i = 0; i < heartContainers.RuntimeValue; i ++)
        {
            if (i < hearts.Length)
            {
                hearts[i].gameObject.SetActive(true);
                hearts[i].sprite = fullHeart;
            }
        }
    }

    public void UpdateHearts()
    {
        InitHearts();
        //makes sure player does not have more then 5 health
        if (playerCurrentHealth.RuntimeValue > 5)
        {
            playerCurrentHealth.RuntimeValue = 5;
        }
        float tempHealth = playerCurrentHealth.RuntimeValue;

        for (int i = 0; i < 5; i ++)
        {
            if (tempHealth - (i) <= .5 && tempHealth - (i) > 0)
            {
                //half full heart
                 hearts[i].sprite = halfFullHeart;
            }else if (i < tempHealth)
            {
                //Full Heart
                hearts[i].sprite = fullHeart;
                
            }else if( i >= tempHealth)
            {
                //empty heart
                hearts[i].sprite = emptyHeart;
            }
            

        }

    }

}
