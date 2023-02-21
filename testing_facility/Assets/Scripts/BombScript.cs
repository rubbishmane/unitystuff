using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    public ParticleSystem ps;
    public Renderer ThisObjectsRenderer;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ThisObjectsRenderer = GetComponent<Renderer>();
    }
    void OnCollisionEnter(Collision col)
    {
        
        ps.Play();
        StartCoroutine(delayBeforeDestroy());
        
        
        
    }

    void Explode()
    {
        ps.Play();
    }
    IEnumerator delayBeforeDestroy()
    {
        gameObject.SetActive(false);
        yield return new WaitForSeconds(3f);
        

    }

   
}
