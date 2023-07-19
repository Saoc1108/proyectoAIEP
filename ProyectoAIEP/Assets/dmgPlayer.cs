using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dmgPlayer : MonoBehaviour
{
    public GameObject player;
    public int _dmg;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        player.GetComponent<playerHealth>().dmg(_dmg);
        
    }
}
