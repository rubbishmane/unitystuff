using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{

    public ParticleSystem ps;
    

    public GameObject player;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        
        
    }
    void OnCollisionEnter(Collision col)
    { 
        ps.Play();
    }

   

    public void Deploy()
    {
        Instantiate(gameObject, new Vector3(player.transform.position.x, player.transform.position.y + 20, player.transform.position.z), Quaternion.identity);

    }

   
}
