using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]
    KeyEnum type;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("frank"))
        {
            other.GetComponent<Inv>().takeKey(type);
            Destroy(gameObject);
        }
    }
}
