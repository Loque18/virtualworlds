using UnityEngine;
using TMPro;
using Photon.Realtime;

public class RoomItem : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI info;

    public RoomInfo room_info { get; private set; }

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        print(roomInfo.Name);
        room_info = roomInfo;
        info.text = roomInfo.MaxPlayers + ", " + roomInfo.Name;
    } 
}