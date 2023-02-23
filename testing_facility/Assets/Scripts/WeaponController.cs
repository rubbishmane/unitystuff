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

    
    void Start()
    {
        CanDrop = true;
    }
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            Physics.Raycast(transform.position,Vector3.forward, out BombHit, maxDistance);
            
            Debug.Log(BombHit.distance);
            CanDrop = false;
            Instantiate(bomb, new Vector3(0, 20f, 0), Quaternion.identity);
            StartCoroutine(dropDelay());
            
            
        }


    }

    IEnumerator dropDelay()
    {
        yield return new WaitForSeconds(5);
        
        CanDrop = true;
    
    }
}
