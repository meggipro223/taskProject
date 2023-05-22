using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Playermovement thePlayer;
    private CameraFollower theCamera;
    public Vector2 startDirection;
    public string point;

    void Start()
    {

        thePlayer = FindObjectOfType<Playermovement>();

        if (thePlayer.startPoint == point)
        {
            thePlayer.transform.position = transform.position;
            thePlayer.lastMove = startDirection;

            theCamera = FindObjectOfType<CameraFollower>();
            theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
        }
    }
}
