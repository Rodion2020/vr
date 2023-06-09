using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private ParticleSystem PS;

    void Awake()
    {
        PS = GetComponent<ParticleSystem>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButtonDown("Fire1") || OVRInput.GetDown(OVRInput.Button.One))
        {
            PS.Play();
        }
        else if ( Input.GetButtonUp("Fire1") || OVRInput.GetUp(OVRInput.Button.One))
        {
            PS.Stop();
        }
    }
}
