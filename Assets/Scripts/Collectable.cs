using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public float rps = 50f;
    public float floatDuration = 2f;
    public float floatSpeed = 0.07f;
    public float floatElapsed = 0;
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
        floatElapsed += Time.deltaTime;
        if(floatElapsed >= floatDuration)
        {
            floatElapsed = 0;
            floatSpeed *= -1;
        }

    }
}
