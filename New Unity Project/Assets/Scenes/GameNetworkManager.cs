using UnityEngine;
using Photon.Pun;

public class GameNetworkManager : MonoBehaviourPunCallbacks
{
    GameObject localPlayerInstance = null;


    private void Start()
    {
        PhotonNetwork.Instantiate("soyomvre", Vector3.zero, Quaternion.identity);
   
    }

    

}
