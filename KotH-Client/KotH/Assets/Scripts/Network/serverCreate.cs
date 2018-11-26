using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class serverCreate : MonoBehaviour {

    [SerializeField]
    private uint roomSize = 5;
    private string roomNameDefault = "OfficalServer - King Of The Kill AU #";

    private string roomName;

    private NetworkManager networkManager;

    void Start()
    {
        networkManager = NetworkManager.singleton;
        if(networkManager.matchMaker == null)
        {
            networkManager.StartMatchMaker();
        }
    }

    public void SetRoomName(string _name)
    {
        roomName = _name;
    }

    public void CreateRoom()
    {
        roomName = roomNameDefault + Random.Range(1,20);
        Debug.Log("Creating Server: " + roomName + " Max Players: " + roomSize);
        networkManager.matchMaker.CreateMatch(roomNameDefault, roomSize, true, "", "", "", 0, 1, networkManager.OnMatchCreate);
    }
}
