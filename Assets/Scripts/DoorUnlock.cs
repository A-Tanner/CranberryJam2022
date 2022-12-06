using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorUnlock : MonoBehaviour
{
    [SerializeField]
    private KeyEnum key = KeyEnum.None;
    public Animator animator;
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("frank"))
        {
            if (key == KeyEnum.None)
            {
                animator.SetBool("unlocked", true);
            }
            else
            {
                animator.SetBool("unlocked", other.GetComponent<Inv>().checkKey(key));

                if (!other.GetComponent<Inv>().checkKey(key))
                {
                    StartCoroutine(GameObject.FindGameObjectWithTag("hint").GetComponent<HintText>().StringTimer($"Find the {key} key to unlock!"));
                }
            }
        }
    }
}
