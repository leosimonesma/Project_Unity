using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndDeath : MonoBehaviour
{
    void Update()
    {
        // Détruis l'objet, après 5 secondes :)
        Destroy(gameObject, 5);
    }
}
