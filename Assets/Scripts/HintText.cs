using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintText : MonoBehaviour
{

    public IEnumerator StringTimer(string message)
    {
        gameObject.GetComponent<Text>().text = message;
        yield return new WaitForSeconds(5);
        gameObject.GetComponent<Text>().text = "  ";
    }

}
