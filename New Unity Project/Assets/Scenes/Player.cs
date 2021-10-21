using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Player : MonoBehaviourPunCallbacks
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.photonView.IsMine)
        {
            if (Input.GetKeyDown(KeyCode.W))
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 1);

            if (Input.GetKeyDown(KeyCode.S))
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -1);
        }
    }
}
