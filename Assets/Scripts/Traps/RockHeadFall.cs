using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHeadFall : MonoBehaviour
{
    public GameObject gm;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gm.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }  
    }
}
