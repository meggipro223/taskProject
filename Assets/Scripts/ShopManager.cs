/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ShopManager : MonoBehaviour
{

    public int[,] shopItems = new int[4, 4];
    public CoinManager coinManager;
    public TextMeshProUGUI coinsText;
    GameObject ButtonRef;
    private Animator playerAnimator;

    GameObject blueHat, roseHat;
    GameObject firstSoldier, player;

    // Start is called before the first frame update
    void Start()
    {
        GameObject coinManagerObject = GameObject.Find("CoinManager");

        // Provjera postoji li CoinManager objekt u sceni
        if (coinManagerObject != null)
        {
            // Dohvaćanje referencu na CoinManager komponentu
            coinManager = coinManagerObject.GetComponent<CoinManager>();
        }
        else
        {
            Debug.LogError("CoinManagerObject nije pronađen u sceni!");
        }

        coinsText.text = "Coins:" + coinManager.coins.ToString();
        ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
            playerAnimator = player.GetComponent<Animator>();

        blueHat = player.transform.Find("BlueHat").gameObject;
        roseHat = player.transform.Find("RoseHat").gameObject;
        firstSoldier = player.transform.Find("FirstSoldier").gameObject;

        //id
        shopItems[1, 1] = 1;
        //shopItems[1, 2] = 2;
        //shopItems[1, 3] = 3;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        //price
        shopItems[2, 1] = 60;
        //shopItems[2, 2] = 70;
       // shopItems[2, 3] = 80;
        shopItems[2, 2] = 35;
        shopItems[2, 3] = 45;

        //quantity
        shopItems[3, 1] = 0;
        //shopItems[3, 2] = 0;
        //shopItems[3, 3] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;

    }

 

    public void Buy() {
     
        if (coinManager.coins >= shopItems[2, ButtonRef.GetComponent <ButtonInfo>().itemId]) {

            coinManager.coins -= shopItems[2, ButtonRef.GetComponent <ButtonInfo>().itemId];
            shopItems[3, ButtonRef.GetComponent <ButtonInfo>().itemId]++;
            coinsText.text = "Coins:" + coinManager.coins.ToString();
            ButtonRef.GetComponent<ButtonInfo>().quantityText.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().itemId].ToString();

            //OVDE TREBA DA ISPISES KOD AKO KLIKNE NA ODREDJENI BUTTON DA SE AKTIVIRA PANEL! PITAJ CHATA KAKO TO DA URADI NA KLIK ID A NE NA EVENT
   
            switch (ButtonRef.GetComponent<ButtonInfo>().itemId)
            {
                case 1:
                    ActivateFirstSoldier();
                    break;
                case 2:
                    ActivateBlueHat();
                    break;
                case 3:
                    ActivateRoseHat();
                    break;
                default:
                    break;
            }
        }
    }

    void ActivateBlueHat()
    {
        int itemPrice = shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId];
        if (coinManager.coins >= itemPrice)
        {

            coinManager.coins -= itemPrice;
            coinManager.coinText.text = "Coins:" + coinManager.coins.ToString();

            blueHat.SetActive(true);
            roseHat.SetActive(false);
            print("blue");

        }
    }

     void ActivateRoseHat()
    {
        int itemPrice = shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId];
        if (coinManager.coins >= itemPrice)
        {

            coinManager.coins -= itemPrice;
            coinManager.UpdateCoinText();

            roseHat.SetActive(true);
            blueHat.SetActive(false);
            print("rose");
        }
    }

    void ActivateFirstSoldier()
    {
        int itemPrice = shopItems[2, ButtonRef.GetComponent<ButtonInfo>().itemId];
        if (coinManager.coins >= itemPrice)
        {

            coinManager.coins -= itemPrice;
            coinManager.coinText.text = "Coins:" + coinManager.coins.ToString();

            firstSoldier.SetActive(true);
            blueHat.SetActive(false);
            roseHat.SetActive(false);
            //playerAnimator.enabled = false;
            print("soldier");
        }
    }


}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public int[,] shopItems = new int[4, 4];
    public CoinManager coinManager;
    public TextMeshProUGUI coinsText;
    public GameObject blueHat;
    public GameObject roseHat;
    public GameObject firstSoldier;
    public GameObject player;
    public GameObject ButtonRef;
    public Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
   

        GameObject coinManagerObject = GameObject.Find("CoinManager");

       
        if (coinManagerObject != null)
        {
           
            coinManager = coinManagerObject.GetComponent<CoinManager>();
        }
        else
        {
            Debug.LogError("CoinManagerObject nije pronađen u sceni!");
        }

        coinsText.text = "Coins:" + coinManager.coins.ToString();
        ButtonRef = EventSystem.current.currentSelectedGameObject;

        player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
            playerAnimator = player.GetComponent<Animator>();

        blueHat = player.transform.Find("BlueHat").gameObject;
        roseHat = player.transform.Find("RoseHat").gameObject;
        firstSoldier = player.transform.Find("FirstSoldier").gameObject;

        //id
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        //price
        shopItems[2, 1] = 60;
        shopItems[2, 2] = 35;
        shopItems[2, 3] = 45;

        //quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
    }

    public void Buy(GameObject buttonRef)
    {
        if (coinManager.coins >= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemId])
        {
            Debug.Log("USLI SMO ");
            coinManager.coins -= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemId];
            shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemId]++;
            coinsText.text = "Coins:" + coinManager.coins.ToString();
            buttonRef.GetComponent<ButtonInfo>().quantityText.text = shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemId].ToString();

            switch (buttonRef.GetComponent<ButtonInfo>().itemId)
            {
                case 1:
                    ActivateFirstSoldier(buttonRef);
                    break;
                case 2:
                    ActivateBlueHat(buttonRef);
                    break;
                case 3:
                    ActivateRoseHat(buttonRef);
                    break;
                default:
                    break;
            }
        }
    }

    void ActivateBlueHat(GameObject buttonRef)
    {

            blueHat.SetActive(true);
            roseHat.SetActive(false);
            print("blue");
        
    }

    void ActivateRoseHat(GameObject buttonRef)
    {

            roseHat.SetActive(true);
            blueHat.SetActive(false);
            print("rose");
        }
    

    void ActivateFirstSoldier(GameObject buttonRef)
    {
         
            firstSoldier.SetActive(true);
            blueHat.SetActive(false);
            roseHat.SetActive(false);
            print("soldier");
        
    }
}
