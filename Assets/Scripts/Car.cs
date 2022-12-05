using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

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
                StartCoroutine(GameObject.FindGameObjectWithTag("hint").GetComponentInChildren<HintText>().StringTimer("Revive 5 turkeys and find the sugar key!"));
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject.FindGameObjectWithTag("hint").GetComponent<Text>().text = "Revive 5 turkeys and find the sugar key!";
    }
}
