using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SellButtonInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public int sellItemId;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI quantityText;
    public GameObject sellManager;

    // Update is called once per frame
    void Update()
    {

        priceText.text = "Price: $" + sellManager.GetComponent<SellManager>().shopItems[2, sellItemId].ToString();
        quantityText.text = sellManager.GetComponent<SellManager>().shopItems[3, sellItemId].ToString();

    }
}
