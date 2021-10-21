using Photon.Pun;
using Photon.Realtime;
using Digizard.VCH.Scenes;
using UnityEngine.SceneManagement;

public class Connection : MonoBehaviourPunCallbacks
{    
    public MasterManager master;

    void Start()
    {
        print("Connecting to server");
        PhotonNetwork.GameVersion = master.GameSettings.GameVersion;
        PhotonNetwork.NickName = master.GameSettings.Nickname;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        print(" connected sucessfully to master ");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene((int)SceneList.LOBBY);
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print($"disconnected from server for reason {cause.ToString()}");        
    }
}
