using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;
	public float speed = 12f;
    public GameObject[] myObjects;
   

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("collectibles"))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5,9), 6,Random.Range(-23,4));
            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            FindObjectOfType<pickup>().Pickup(other);
        }
    }
    
  
}
