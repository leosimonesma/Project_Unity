using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SRP_Inventory : MonoBehaviour
{

    [SerializeField] int[] Ingredient_Inventory = new int[6];

    private void Inv_Reset() {

        for (int i = 0; i < Ingredient_Inventory.Length; i++)
        {
            Ingredient_Inventory[i] = 0;
        }

    }

    public bool Inv_Add(int set) {

        for (int i = 0; i < Ingredient_Inventory.Length; i++) {

            if (Ingredient_Inventory[i] != 0) {

                Ingredient_Inventory[i] = set;
                return true;
            }
        }

        return false;
    }

    private bool Inv_Full() {

        for (int i = 0; i < Ingredient_Inventory.Length; i++) {

            if (Ingredient_Inventory[i] != 0) {

                return false;
            }
        }

        return true;
    }

    public void Inv_Check() {

        if (Inv_Full()) {

            Debug.Log("CALL COMBO CHECK");
            Inv_Reset();

        }
    }


}



