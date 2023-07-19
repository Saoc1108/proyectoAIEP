using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public int vida;
    public Text vidaTxt;
    public AudioClip dmgClip;
    public AudioSource _source;
    public GameObject deadScreen;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    public void dmg(int dmg)
    {
        vida -= dmg;
        vidaTxt.text = vida.ToString();
        _source.PlayOneShot(dmgClip);

        if(vida <= 0)
        {
            dead();
        }
    }

    public void updateTxt()
    {
        vidaTxt.text = vida.ToString();
    }

    void dead()
    { 
        deadScreen.SetActive(true);
        player.GetComponent<playerMovement>().lockInput = true;
    }
}
