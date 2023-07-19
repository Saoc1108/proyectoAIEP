using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    private Rigidbody2D playerBody;
    public bool lockInput;

    public AudioClip jumpClip;
    public AudioSource _source;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        _source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(lockInput)
        {
            return;
        }

        var horizontanlInput = Input.GetAxisRaw("Horizontal");
        var horizontanlSpeed = (horizontanlInput*5.0f);
        playerBody.velocity = new Vector2(horizontanlSpeed, playerBody.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            playerBody.velocity = new Vector2(horizontanlSpeed, 5.0f);
            _source.PlayOneShot(jumpClip);
        }
    }
}
