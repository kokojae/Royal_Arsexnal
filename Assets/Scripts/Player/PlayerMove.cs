using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D playerRigidbody = null;
    public float speed = 7;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movment = new Vector2(x, y);
        playerRigidbody.velocity = movment.normalized * speed;
    }
}
