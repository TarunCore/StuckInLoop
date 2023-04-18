using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio1 : MonoBehaviour
{
    public AudioSource fire;
    // Start is called before the first frame update
    void Start()
    {
        fire = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            fire.Play();
        }
    }
}
