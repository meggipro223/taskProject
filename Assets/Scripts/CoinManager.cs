using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public int coins; 
    public TextMeshProUGUI coinText; 

    private void Update()
    {
        UpdateCoinText();
    }

    public void UpdateCoinText()
    {
        coinText.text = "Coins: " + coins.ToString();
    }
}
