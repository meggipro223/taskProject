﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInfo : MonoBehaviour
{
    public int itemId;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI quantityText;
    public GameObject shopManager;
    GameObject blueHat, roseHat;
    GameObject firstSoldier, secondSoldier, thirdSoldier;


    // Update is called once per frame
    void Update()
    {

        priceText.text = "Price: $" + shopManager.GetComponent<ShopManager>().shopItems[2, itemId].ToString();
        quantityText.text = shopManager.GetComponent<ShopManager>().shopItems[3, itemId].ToString();

    }

     void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

         blueHat = player.transform.Find("BlueHat").gameObject;
         roseHat = player.transform.Find("RoseHat").gameObject;

        firstSoldier = player.transform.Find("FirstSoldier").gameObject;
    }

    public void ActivateBlueHat()
    {
        
        blueHat.SetActive(true);
        roseHat.SetActive(false); 
    }

    public void ActivateRoseHat()
    {  
        
        roseHat.SetActive(true);
        blueHat.SetActive(false);

    }

    public void ActivateFirstSoldier()
    {

        firstSoldier.SetActive(true);
        blueHat.SetActive(false);
        roseHat.SetActive(false);

    }


}
