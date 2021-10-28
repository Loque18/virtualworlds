using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Digizard.VCH.Scenes;
using Photon.Realtime;
using TMPro;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject playerPref;
    private string current_room = "";

    [SerializeField]
    TextMeshProUGUI tpro_createRoom;    

    void Start()
    {
        //PhotonNetwork.Instantiate(this.playerPref.name, new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
    }


    /* JOIN ROOM */
    void joinRoom(string _roomname)
    {
        current_room = _roomname;
        PhotonNetwork.LeaveLobby();
    }

    public override void OnLeftLobby()
    {
        if (current_room.Length > 0)
            PhotonNetwork.JoinRoom(current_room);
    }

    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene((int)SceneList.GAME);
        
    }

    public IEnumerator wait(float time)
    {
        yield return new WaitForSeconds(time);        
    }

    public void onClick_JoinToRoom(string roomname)
    {
        if (!PhotonNetwork.IsConnected)
        {
            print("not connected to server");
            return;
        }
        joinRoom(roomname);
    }

    /* CREATE ROOM */

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
        PhotonNetwork.CreateRoom(tpro_createRoom.text, new RoomOptions { MaxPlayers = 4, IsVisible = true }, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        print("Created room successfully");
        PhotonNetwork.LeaveLobby();
        current_room = tpro_createRoom.text;
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print($"Room creation failed, reason:{ message }");
    }


    public override void OnConnectedToMaster()
    {
        print(" connected to master ");
        //PhotonNetwork.JoinRoom(_roomName);
    }

}
