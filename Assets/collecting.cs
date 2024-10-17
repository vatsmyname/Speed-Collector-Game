using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collecting : MonoBehaviour
{   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            gameObject.SetActive (false);
            
        }
    }
    // Start is called before the first frame update
    
}
