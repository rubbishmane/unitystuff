using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    public ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }
    void OnCollisionEnter(Collision col)
    {
        
        ps.Play();
        GameObject.GetComponent<Renderer>.enabled = false;
        
        
    }

    void Explode()
    {
        ps.Play();
    }
}
