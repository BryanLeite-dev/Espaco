using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public int speed;
    private float moveH, moveV;
    private Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        transform.Rotate(new Vector3(x: 0, y: 1, z: 0));
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        player.velocity = new Vector2(moveH * speed, moveV * speed);
    }    
}
