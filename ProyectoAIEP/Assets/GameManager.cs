using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public checkPoint checkPoint;
    public Transform _StartPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetLevel()
    {
        player.GetComponent<playerHealth>().vida = 5;
        player.GetComponent<playerMovement>().lockInput = false;
        player.transform.position = _StartPoint.position;
        player.GetComponent<playerHealth>().updateTxt();
    }

    public void resetCheckpoint()
    {
        player.GetComponent<playerHealth>().vida = 5;
        player.GetComponent<playerMovement>().lockInput = false;
        player.GetComponent<playerHealth>().updateTxt();
        if(checkPoint.active)
        { 
            player.transform.position = checkPoint._check1.position;
        }
        else
        {
            player.transform.position = _StartPoint.position;
        }
        
    }
}
