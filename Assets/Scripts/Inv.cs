using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inv : MonoBehaviour
{
    public int turkeyCount { get; private set; }
    public bool hasGun { get; private set; }
    private List<KeyEnum> keys;

    public void takeTurkey()
    {
        turkeyCount++;
    }

    public void takeKey(KeyEnum type)
    {
        keys.Add(type);
    }

    public void takeGun()
    {
        hasGun = true;
    }

}
