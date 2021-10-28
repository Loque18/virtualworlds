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


    //string _roomName = "";



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



    string roomJoinName = "";





    /*public override void OnJoinedRoom()
    {
        SceneManager.LoadScene((int)SceneList.GAME);
    }*/

}
