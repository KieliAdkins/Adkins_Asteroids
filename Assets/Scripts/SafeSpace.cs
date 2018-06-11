using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeSpace : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
       
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}