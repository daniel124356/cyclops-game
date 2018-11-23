using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerMovement : NetworkBehaviour {

    public float speed = 1000;

    public Rigidbody rb;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        if (!isLocalPlayer)
        {
            return;
        }

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
	}
}
