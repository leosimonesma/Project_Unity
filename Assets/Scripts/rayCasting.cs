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
                Debug.Log("Curseur sur un Ingrediant !");         // D�tecte l'objet vis� qu'est l'ingr�diant
            }
            if (Input.GetMouseButton(0) && hit.transform.CompareTag("Ingrediant"))
            {
                hit.collider.gameObject.SetActive(false);       // D�sactiver l'objet ayant le Tag Ingrediant et apr�s avoir cliqu� sur clic gauche
                Debug.Log("Ingrediant Detruit !");
            }
        }
    }
}
