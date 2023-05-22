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
    GameObject blueHat, roseHat;
    GameObject firstSoldier, player;
    [HideInInspector]
    public Playermovement playerScript;
    public Animator playerAnimator;
    private CoinManager coinManager;

    // Update is called once per frame
    void Update()
    {

        priceText.text = "Price: $" + shopManager.GetComponent<ShopManager>().shopItems[2, itemId].ToString();
        quantityText.text = shopManager.GetComponent<ShopManager>().shopItems[3, itemId].ToString();

    }

    void Start()
    {
        coinManager = FindObjectOfType<CoinManager>();
        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
            playerAnimator = player.GetComponent<Animator>();

        blueHat = player.transform.Find("BlueHat").gameObject;
        roseHat = player.transform.Find("RoseHat").gameObject;

        firstSoldier = player.transform.Find("FirstSoldier").gameObject;
    }

    public void ActivateBlueHat()
    {
        int itemPrice = shopManager.GetComponent<ShopManager>().shopItems[2, itemId];
        if (coinManager.coins >= itemPrice)
        {

            coinManager.coins -= itemPrice;
            coinManager.coinText.text = "Coins:" + coinManager.coins.ToString();

            blueHat.SetActive(true);
            roseHat.SetActive(false);
            print("fdsfsdfdf");

        }
    }

    public void ActivateRoseHat()
    {
        int itemPrice = shopManager.GetComponent<ShopManager>().shopItems[2, itemId];
        if (coinManager.coins >= itemPrice)
        {

            coinManager.coins -= itemPrice;
            coinManager.UpdateCoinText();

            roseHat.SetActive(true);
            blueHat.SetActive(false);
            print("fdsfsdfdf");
        }
    } 

    public void ActivateFirstSoldier()
    {
        int itemPrice = shopManager.GetComponent<ShopManager>().shopItems[2, itemId];
        if (coinManager.coins >= itemPrice)
        {

            coinManager.coins -= itemPrice;
            coinManager.coinText.text = "Coins:" + coinManager.coins.ToString();

            firstSoldier.SetActive(true);
            blueHat.SetActive(false);
            roseHat.SetActive(false);
            playerAnimator.enabled = false;
            print("fdsfsdfdf");
        }
    } 

}
