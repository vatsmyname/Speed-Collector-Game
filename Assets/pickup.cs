using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickup : MonoBehaviour
{
    public TextMeshProUGUI pick;
    public float delay=1f,a,b;
    // Start is called before the first frame update
    void Update()
    {
        delay-=1*Time.deltaTime;
        if (delay<=0)
        {
            pick.text = " ";
        }
    }
    public void Pickup(Collision other)
    {
    if (other.gameObject.name=="Sphere(Clone)")
    {
        pick.text = "Sphere";
        delay=1f;
        a++;
    }
    if (other.gameObject.name=="Capsule(Clone)")
    {
        pick.text = "Capsule";
        delay=1f;
        b++;
    }
    }
}
