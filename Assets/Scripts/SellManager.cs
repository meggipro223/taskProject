using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class SellManager : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public float coins;
    public TextMeshProUGUI coinsText;

    // Start is called before the first frame update
    void Start()
    {
        coinsText.text = "Coins:" + coins.ToString();

        //id
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;

        //price
        shopItems[2, 1] = 60;
        shopItems[2, 2] = 70;

        //quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;

    }

    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId])
        {

            coins += shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId];
            shopItems[3, ButtonRef.GetComponent<ButtonInfo>().itemId]++;
            coinsText.text = "Coins:" + coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().quantityText.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().itemId].ToString();

        }
    }
}
