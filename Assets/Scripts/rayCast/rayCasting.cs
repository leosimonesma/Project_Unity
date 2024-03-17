using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class rayCasting : MonoBehaviour
{

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.transform.CompareTag("Ingrediant"))
            {
                Debug.Log("Curseur sur un Ingrediant !");         // Détecte l'objet visé qu'est l'ingrédiant
            }
            if (Input.GetMouseButton(0) && hit.transform.CompareTag("Ingrediant"))
            {
                hit.collider.gameObject.SetActive(false);       // Désactiver l'objet ayant le Tag Ingrediant et après avoir cliqué sur clic gauche
                Debug.Log("Ingrediant Detruit !");
            }
        }
    }
}
