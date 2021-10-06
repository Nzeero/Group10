using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class VelocityTesting : MonoBehaviour
{

    public Telekinesis telekinesis;
    public Player player;
    private Transform handPos;
    private GameObject hand;
    public Vector3 localVelocity;

    private void Start()
    {
       

    }

    private void Update()
    {
        

        localVelocity = transform.InverseTransformDirection(this.GetComponent<HandPhysics>().handCollider.GetComponent<Rigidbody>().velocity);

        if (telekinesis.m_ActiveObject!= null && localVelocity.z >1)
        {
            telekinesis.m_ActiveObject.GetComponent<Rigidbody>().AddForce(Vector3.forward);
            telekinesis.m_fDistance += 1;
            Debug.Log("throwing");
        }
    }
}
