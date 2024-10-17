using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementdisable : MonoBehaviour
{
    public movement move;
    public camerarotate rot;

    // Start is called before the first frame update
    public void GameOver()
    {
        Debug.Log("hm");
        move.enabled = false;
        rot.enabled = false;
    }
}
