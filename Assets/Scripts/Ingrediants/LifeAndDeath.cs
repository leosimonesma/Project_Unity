using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndDeath : MonoBehaviour
{
    [SerializeField] float deathTime = 5f;
    void Update()
    {
        // Détruis l'objet, après 5 secondes :)
        Destroy(gameObject, deathTime);
    }
}
