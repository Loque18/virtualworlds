using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class roommananger : MonoBehaviourPunCallbacks
{
    public GameObject playerPref;
    
    void Start()
    {
        PhotonNetwork.Instantiate(this.playerPref.name, new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
    }

       
}
