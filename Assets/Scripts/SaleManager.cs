using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaleManager : MonoBehaviour
{
    public CoinManager coinManager; // Referenca na CoinManager skriptu
    public TextMeshProUGUI coinText; // Referenca na UI tekst koji prikazuje broj novčića

    private void Start()
    {
        UpdateCoinText();
    }

    public void OnSaleButtonPressed()
    {
        coinManager.coins += 50; // Dodajemo 50 novčića na postojeći broj novčića
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        coinText.text = "Coins: " + coinManager.coins.ToString();
    }
}

