using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlComplete : MonoBehaviour
{
    public GameObject _check1;
    public AudioClip dmgClip;
    public AudioSource _source;

    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        _check1.SetActive(true);
        _source.PlayOneShot(dmgClip);
        
    }
}
