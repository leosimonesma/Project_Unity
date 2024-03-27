using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeAndDeath : MonoBehaviour
{
    [SerializeField] float deathTime = 5f;
    [SerializeField] float invisibleTime = 1f;

    private void Start()
    {
        StartCoroutine(Invisible());
    }

    void Update()
    {
        // Détruis l'objet, après 5 secondes :)
        Destroy(gameObject, deathTime);
    }

    private IEnumerator Invisible()
    {
        yield return new WaitForSeconds(invisibleTime);
        this.GetComponent<MeshRenderer>().enabled = true;
    }

}
