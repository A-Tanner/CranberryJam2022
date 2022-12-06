using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inv : MonoBehaviour
{
    public int turkeyCount { get; private set; }
    public bool hasGun { get; private set; }

    private List<KeyEnum> keys = new();
    [SerializeField]
    private GameObject gun;
    [SerializeField]
    private GameObject beam;
    private void Update()
    {
        if (hasGun && Input.GetMouseButton(0))
        {
            gun.GetComponentInChildren<ParticleSystem>().Play();
            beam.SetActive(true);
        } else
        {
             beam.SetActive(false);
        }
    }

    public void takeTurkey()
    {
        turkeyCount++;

        StartCoroutine(GameObject.FindGameObjectWithTag("hint").GetComponent<HintText>().StringTimer($"Revived {turkeyCount} turkey"+ (turkeyCount>1 ? "s" : "")+"!"));
    }

    public void takeKey(KeyEnum type)
    {
        keys.Add(type);
    }

    public void takeGun()
    {
        hasGun = true;
        gun.SetActive(true);
    }

    public bool checkKey(KeyEnum type)
    {
        return keys.Contains(type);
    }
}
