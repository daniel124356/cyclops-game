using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class pingCounter : NetworkBehaviour {

    private NetworkClient client;
    public float pingers = 0.0f;
    public Text textPing;
    
    void Start()
    {
        client = GameObject.Find("Camera").GetComponent<NetworkManager>().client;
    }
    void Update()
    {
        Debug.Log(client.GetRTT());
    }
}