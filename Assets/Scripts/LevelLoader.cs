using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string levelToLoad;
    public string exitPoint;
    private Playermovement player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Playermovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
            player.startPoint = exitPoint;
        }
    }
}
