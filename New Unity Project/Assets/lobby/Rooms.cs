using System.Collections;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Digizard.VCH.Scenes;
using UnityEngine.SceneManagement;

public class Rooms : MonoBehaviourPunCallbacks
{
    [SerializeField]
    TextMeshProUGUI tpro_roomName; 

    //string _roomName = "";

    public void onClick_CreateRoom()
    {
        if (!PhotonNetwork.IsConnected)
        {
            print("not connected to server");
            return;
        }        
        RoomOptions ops = new RoomOptions();
        ops.MaxPlayers = 4;
        ops.IsVisible = true;
        PhotonNetwork.CreateRoom(tpro_roomName.text, new RoomOptions { MaxPlayers = 4, IsVisible = true }, TypedLobby.Default);
    }

    public void onClick_JoinRoom()
    {
        PhotonNetwork.LeaveLobby();
    }

    public override void OnJoinedLobby()
    {
       // Photon.Re
    }

    public override void OnLeftLobby()
    {
        if(roomJoinName.Length > 0)
        {
            PhotonNetwork.JoinRoom(roomJoinName);
        }
        else
        {
            PhotonNetwork.JoinRoom("asd");
        }
    }

    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene((int)SceneList.GAME);
    }

    string roomJoinName = "";

    public override void  OnCreatedRoom()
    {
        print("Created room successfully");
        PhotonNetwork.LeaveLobby();
        roomJoinName = tpro_roomName.text;
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print($"Room creation failed, reason:{ message }");
    }

    /*public override void OnJoinedRoom()
    {
        SceneManager.LoadScene((int)SceneList.GAME);
    }*/

    public override void OnConnectedToMaster()
    {
        print(" connected sucessfully to master ");
        //PhotonNetwork.JoinRoom(_roomName);
    }
}
