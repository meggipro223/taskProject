using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class SellManager : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public TextMeshProUGUI coinsText;
    public CoinManager coinsManager;

    // Start is called before the first frame update
    void Start()
    {
        coinsText.text = "Coins:" + coinsManager.coins.ToString();

        //id
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;

        //price
        shopItems[2, 1] = 5;
        shopItems[2, 2] = 5;

        //quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;

    }

    public void Sell()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        int sellItemId = ButtonRef.GetComponent<SellButtonInfo>().sellItemId;
        int currentQuantity = shopItems[3, sellItemId];


        if (currentQuantity < 1)
        {

            coinsManager.coins += shopItems[2, ButtonRef.GetComponent<SellButtonInfo>().sellItemId];
            shopItems[3, ButtonRef.GetComponent<SellButtonInfo>().sellItemId]++;
            coinsText.text = "Coins:" + coinsManager.coins.ToString();
            ButtonRef.GetComponent<SellButtonInfo>().quantityText.text = shopItems[3, ButtonRef.GetComponent<SellButtonInfo>().sellItemId].ToString();

        }
    }
}
