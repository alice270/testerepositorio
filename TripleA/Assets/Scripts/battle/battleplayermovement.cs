using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class battleplayermovement : MonoBehaviour
{ 
    public Rigidbody2D rbody;
    private float speed = 10f;


    private void Update()
    {
        UnityEngine.Vector2 movement = new UnityEngine.Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rbody.MovePosition(rbody.position + movement * Time.deltaTime * speed);
    }
}

       
