using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class rayCasting : MonoBehaviour
{
    string[] ingredientTags = { "Ingredient_Burrito", "Ingredient_Champi", "Ingredient_Poussiere", "Ingredient_DentDrake", "Ingredient_CoeurGolem", "Ingredient_OeilCyclope", "Ingredient_Sablier", "Ingredient_Cristaux", "Ingredient_PotionVerte", "Ingredient_PotionViolette" };
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (ingredientTags.Contains(hit.transform.tag))
            {
                Debug.Log("Curseur sur un Ingrediant !");         // Détecte l'objet visé qu'est l'ingrédiant
            }
            if (Input.GetMouseButtonDown(0) && ingredientTags.Contains(hit.transform.tag))
            {
                hit.collider.gameObject.SetActive(false);       // Désactiver l'objet ayant le Tag Ingrediant et après avoir cliqué sur clic gauche
                Debug.Log("Ingrediant Detruit !");
            }
        }
    }
}
