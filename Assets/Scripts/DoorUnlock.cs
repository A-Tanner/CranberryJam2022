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
            }
        }
    }
}
