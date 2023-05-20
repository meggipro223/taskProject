using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPanel : MonoBehaviour
{
    private Playermovement player;

    [SerializeField]
    private GameObject itemPanel;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Playermovement>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            itemPanel.SetActive(true);
        }
    }
}
