using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPhysics : MonoBehaviour
{
    public float rps = 50f;
    public float floatDuration = 2f;
    public float floatSpeed = 0.07f;
    public float floatElapsed = 0;
    // Start is called before the first frame update
    void Update()
    {
        this.transform.Rotate(new Vector3(0, rps * Time.deltaTime, 0), Space.World);
        float floatDist = floatSpeed * Time.deltaTime;
        this.transform.Translate(new Vector3(0, floatDist, 0), Space.World);
        floatElapsed += Time.deltaTime;
        if (floatElapsed >= floatDuration)
        {
            floatElapsed = 0;
            floatSpeed *= -1;
        }

    }
}
