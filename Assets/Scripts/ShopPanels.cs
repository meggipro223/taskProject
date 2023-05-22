using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPanels : MonoBehaviour
{
    private Playermovement player;

    [SerializeField]
    private GameObject talkPanel;

    [SerializeField]
    private GameObject buyPanel;

    [SerializeField]
    private GameObject sellPanel;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Playermovement>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            talkPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ExitBtnForTalkPanel()
    {
        talkPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitBtnForBuyPanel()
    {
        buyPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ExitBtnForSellPanel()
    {
        sellPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void BuyBtn()
    {
        buyPanel.SetActive(true);
        talkPanel.SetActive(false);
    }

    public void SellBtn()
    {
        sellPanel.SetActive(true);
        talkPanel.SetActive(false);
    }

}
