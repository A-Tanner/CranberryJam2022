using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turkey : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("contact");
        if (other.CompareTag("ray"))
        {
            gameObject.GetComponent<Animator>().SetBool("revived", true);
            GameObject.FindGameObjectWithTag("frank").GetComponent<Inv>().takeTurkey();
        }
    }
}
