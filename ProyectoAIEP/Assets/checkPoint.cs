using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public Transform _check1;
    public bool active;
    public AudioClip dmgClip;
    public AudioSource _source;

    // Start is called before the first frame update
    void Start()
    {
        _check1 = this.transform;
        _source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        active = true;
        _source.PlayOneShot(dmgClip);
        
    }
}
