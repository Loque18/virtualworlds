using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject player; 

    void Start()
    {
        StartCoroutine(spawn(5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawn(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);

        Instantiate(player, new Vector3(0, 0, 0), Quaternion.identity, null);
    }
}
