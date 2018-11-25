using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerSetup : NetworkBehaviour {

    [SerializeField]
    Behaviour[] componentsToDisable;

    private GameObject disable;

	// Use this for initialization
	void Start () {
		if(!isLocalPlayer)
        {
            for(int i = 0; i < componentsToDisable.Length; i++)
            {
                componentsToDisable[i].enabled = false;
            }
        } else
        {
            disable = GameObject.Find("MenuCamera");

            disable.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
