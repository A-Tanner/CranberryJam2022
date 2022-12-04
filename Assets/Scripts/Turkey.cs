using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turkey : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("revivify"))
        {
            GameObject.FindGameObjectWithTag("frank").GetComponent<Inv>().takeTurkey();
            //Set up ai pathfinding
        }
    }
}
