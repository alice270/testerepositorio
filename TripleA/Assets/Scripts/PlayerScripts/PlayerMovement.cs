using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public Rigidbody2D rbody;
    private float speed = 10f;
    public Animator anim;

    private void Update()
    {
        UnityEngine.Vector2 movement = new UnityEngine.Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(movement != UnityEngine.Vector2.zero)
        {
            anim.SetBool("is_walking", true);
            anim.SetFloat("input_x", movement.x);
            anim.SetFloat("input_y", movement.y);
        }
        else
        {
            anim.SetBool("is_walking", false);
        }
        rbody.MovePosition(rbody.position + movement * Time.deltaTime * speed);
    }
}
