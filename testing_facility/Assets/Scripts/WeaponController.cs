using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject stick, fish, hand, glock, sniper, bomb;
    [SerializeField] GameObject player;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(bomb, new Vector3(0, 20f, 0), Quaternion.identity);
        }
    }
}
