using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerMovement : NetworkBehaviour {

    public float speed = 1000;

    public Rigidbody rb;
    public float test = 0.1f;


    [SyncVar]
    Vector3 realPosition = Vector3.zero;
    [SyncVar]
    Quaternion realRotation;
    private float updateInterval;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        //float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("MOVE OFORWARD CUNT");
            rb.AddForce(transform.forward * speed);
        }

        //Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        //rb.MovePosition(transform.position + movement);


        if(isLocalPlayer)
        {
            updateInterval += Time.deltaTime;
            if (updateInterval > 0.11f)
            {
                updateInterval = 0;
                CmdSync(transform.position, transform.rotation);
            }
        } else
        {
            transform.position = Vector3.Lerp(transform.position, realPosition, Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, realRotation, Time.deltaTime);
            //return;
        }
	}
    [Command]
    void CmdSync(Vector3 position, Quaternion rotation)
    {
        realPosition = position;
        realRotation = rotation;
    }
}
