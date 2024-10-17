using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class counter : MonoBehaviour
{
    public float ct =0f;
    private float st=10f;
    public TextMeshProUGUI Timers;
    bool check=false;
    // Start is called before the first frame update
    void Start()
    {
        ct = st;
    }

    // Update is called once per frame
    void Update()
    {
        ct -=1*Time.deltaTime;
        if (ct>0)
        {
        Timers.text = ct.ToString("0");
        }
        if (ct<=0)
        {
            Timers.text = "0";
            if (check == false)
            {
            FindObjectOfType<movementdisable>().GameOver();
            FindObjectOfType<GameManager>().EndGame();
            
            check = true;
            }
        }
        
        
    }
}
