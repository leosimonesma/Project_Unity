using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class rayCasting : MonoBehaviour
{
    string[] ingredientTags = { "Ingredient_Burrito", "Ingredient_Champi", "Ingredient_Poussiere", "Ingredient_DentDrake", "Ingredient_CoeurGolem", "Ingredient_OeilCyclope", "Ingredient_Sablier", "Ingredient_Cristaux", "Ingredient_PotionVerte", "Ingredient_PotionViolette" };
    private SRP_Inventory Inventory_system;

    private void Start() {
        Inventory_system = this.GetComponent<SRP_Inventory>();
    }

    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (ingredientTags.Contains(hit.transform.tag))
            {
                //Debug.Log("Curseur sur un Ingrediant !");         // Détecte l'objet visé qu'est l'ingrédiant
            }
            if (Input.GetMouseButtonDown(0) && ingredientTags.Contains(hit.transform.tag))
            {
                hit.collider.gameObject.SetActive(false);       // Désactiver l'objet ayant le Tag Ingrediant et après avoir cliqué sur clic gauche
                Inventory_system.inv_call(hit.transform.tag);
                Debug.Log("Ingrediant Detruit ! c'etait un : " + hit.transform.tag);
            }
        }
    }
}
