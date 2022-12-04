using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private float rps = 30f;
    private float floatBound = 0.04f;
    private float floatSpeed = 0.02f;
    private float floatLocation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("frank"))
        {
            
        }
    }    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, rps * Time.deltaTime, 0));
        float floatDist = floatSpeed * Time.deltaTime;
        this.transform.Translate(new Vector3(0, floatDist, 0));
        if (Mathf.Abs(floatLocation) >= floatBound)
        {
            floatSpeed *= -1;
            if (floatSpeed < 0) {
                floatLocation = -floatBound;
            } else
            {
                floatLocation = floatBound;
            }
        }
    }
}
