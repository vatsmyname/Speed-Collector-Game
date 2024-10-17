using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] myObjects;
    void Start()
    {
        for ( int i=0 ; i<myObjects.Length ; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5,9), 6,Random.Range(-23,4));
            Instantiate(myObjects[i], randomSpawnPosition, Quaternion.identity);
            Vector3 randomSpawnPosition1 = new Vector3(Random.Range(-5,9), 6,Random.Range(-23,4));
            Instantiate(myObjects[i], randomSpawnPosition1, Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5,9), 6,Random.Range(-23,4));
            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}
