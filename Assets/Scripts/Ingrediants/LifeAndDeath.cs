using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndDeath : MonoBehaviour
{
    void Update()
    {
        // D�truis l'objet, apr�s 5 secondes :)
        Destroy(gameObject, 5);
    }
}
