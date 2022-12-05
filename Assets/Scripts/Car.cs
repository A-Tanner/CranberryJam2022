using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Car : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("frank"))
        {
            if (other.GetComponent<Inv>().turkeyCount ==5 && other.GetComponent<Inv>().checkKey(KeyEnum.Sugar))
            {
                SceneManager.LoadScene("end");
            } else
            {
                // Print help message
            }
        }
    }
}
