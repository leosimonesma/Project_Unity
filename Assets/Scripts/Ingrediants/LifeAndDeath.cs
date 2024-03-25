using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndDeath : MonoBehaviour
{
    [SerializeField] float deathTime = 5f;
    void Update()
    {
        // D�truis l'objet, apr�s 5 secondes :)
        Destroy(gameObject, deathTime);
    }
}
