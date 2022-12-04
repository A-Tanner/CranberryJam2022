using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("frank"))
        {
            other.GetComponent<Inv>().takeGun();
            Destroy(gameObject);
        }
    }
}
