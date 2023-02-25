using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject stick, fish, hand, glock, sniper, bomb;
    [SerializeField] GameObject player;

    private float maxDistance = 100000f;

    RaycastHit BombHit;

    public bool CanDrop;

    BombScript BombScript;

    

    

    
    void Start()
    {
        CanDrop = true;
        BombScript = bomb.GetComponent<BombScript>();
    }
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0) && bomb.activeSelf)
        {

            BombScript.Deploy();
            
            
            
        }


    }

    IEnumerator dropDelay()
    {
        yield return new WaitForSeconds(5);
        
        CanDrop = true;
    
    }
}
