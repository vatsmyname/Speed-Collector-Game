using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float del =3f;
    public GameObject completed;
    public void Completed()
    {
        completed.SetActive(true);
    }
    public void EndGame ()
    {
        if (gameHasEnded==false)
        {
            gameHasEnded=true;
            Invoke("restart",del);
        }
    }
    // Start is called before the first frame update
    void restart()
    {
        Debug.Log("GAME OVER");
        FindObjectOfType<GameManager>().Completed();
    }
}
