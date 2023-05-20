using System.Collections;
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

    // Update is called once per frame
    void Update()
    {

        priceText.text = "Price: $" + shopManager.GetComponent<ShopManager>().shopItems[2, itemId].ToString();
        quantityText.text = shopManager.GetComponent<ShopManager>().shopItems[3, itemId].ToString();

    }
}
