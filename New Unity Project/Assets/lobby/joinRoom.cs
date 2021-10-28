using UnityEngine;
using TMPro;

public class joinRoom : MonoBehaviour
{

    RoomManager roomManager;

    public TextMeshProUGUI tpro;

    private void Start()
    {
        roomManager = GameObject.FindGameObjectWithTag("roommanager").GetComponent<RoomManager>();
    }

    public void onClick()
    {
       
    }
}
