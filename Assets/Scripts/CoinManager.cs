using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coins = 100; // Početni broj novčića
    public TextMeshProUGUI coinText; // Referenca na UI tekst koji prikazuje broj novčića

    private void Start()
    {
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + coins.ToString();
    }
}
