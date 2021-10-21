using Photon.Pun;
using Photon.Realtime;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class RoomListingMenu : MonoBehaviourPunCallbacks
{
    public RoomItem _roomItem;
    public Transform _content;

    public GameObject roomItemPrefab;

    private List<RoomItem> currentList = new List<RoomItem>();

    private void Start()
    {
        
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        currentList.Clear();
        foreach (RoomInfo info in roomList)
        {

            if(info.RemovedFromList)
            {
                int index = currentList.FindIndex( x => x.room_info.Name == info.Name);
                if(index != -1)
                {
                    Destroy(currentList[index].gameObject);
                    currentList.RemoveAt(index);
                }
            } 
            else
            {
                RoomItem room = (RoomItem)Instantiate(_roomItem, _content);

                if(room != null)
                {
                    room.SetRoomInfo(info);
                    currentList.Add(room);
                }
                
            }

           

           /* GameObject roomBox = Instantiate(roomItemPrefab, _content.transform);

            print(roomBox.ToString());

            currentList.Add(listing.gameObject);*/
            //roomBox.GetComponent<RectTransform>().parent = _content;            
        }        
    }
}
