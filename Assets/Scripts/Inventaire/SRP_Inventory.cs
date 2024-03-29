using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SRP_Inventory : MonoBehaviour
{

    [SerializeField] int Score = 0;

    [SerializeField] int[] Ingredient_Inventory = new int[5];

    [SerializeField] int[] SuperCombo_1 = new int[5];
    [SerializeField] int[] SuperCombo_2 = new int[5];
    [SerializeField] int[] SuperCombo_3 = new int[5];
    [SerializeField] int[] SuperCombo_4 = new int[5];
    [SerializeField] int[] SuperCombo_5 = new int[5];
    [SerializeField] int[] SuperCombo_6 = new int[5];

    string[] ingredientTags = { "Ingredient_Burrito", "Ingredient_Champi", "Ingredient_Poussiere", "Ingredient_DentDrake", "Ingredient_CoeurGolem", "Ingredient_OeilCyclope", "Ingredient_Sablier", "Ingredient_Cristaux", "Ingredient_PotionVerte", "Ingredient_PotionViolette" };

    private void Start() {

        Inv_Reset(Ingredient_Inventory);
        SuperCombo_All_Reset(SuperCombo_1,SuperCombo_2,SuperCombo_3,SuperCombo_4,SuperCombo_5,SuperCombo_6);
    }

    private void Update() {

        if (Input.GetKeyDown(KeyCode.Keypad1)){

            Inv_Reset(Ingredient_Inventory);

        } else if (Input.GetKeyDown(KeyCode.Keypad2)) {

            int _random = UnityEngine.Random.Range(1, 11);

            Inv_Add(_random, Ingredient_Inventory);

        } else if (Input.GetKeyDown(KeyCode.Keypad3)) {

            Debug.Log(Score);

        } else if (Input.GetKeyDown(KeyCode.Keypad4)) {

            Inv_Manual_Check(Ingredient_Inventory, SuperCombo_1, SuperCombo_2, SuperCombo_3, SuperCombo_4, SuperCombo_5, SuperCombo_6) ;

        } else if (Input.GetKeyDown(KeyCode.Keypad5)) {

            Debug.Log("Super combo = " + Inv_SuperCombo_Check(Ingredient_Inventory, SuperCombo_1, SuperCombo_2, SuperCombo_3, SuperCombo_4, SuperCombo_5, SuperCombo_6));
        }
    }

    public void SuperCombo_All_Reset(int[] SuperCombo1, int[] SuperCombo2, int[] SuperCombo3, int[] SuperCombo4, int[] SuperCombo5, int[] SuperCombo6) {

        SuperCombo_Reset(SuperCombo1);
        SuperCombo_Reset(SuperCombo2);
        SuperCombo_Reset(SuperCombo3);
        SuperCombo_Reset(SuperCombo4);
        SuperCombo_Reset(SuperCombo5);
        SuperCombo_Reset(SuperCombo6);

    }

    public void SuperCombo_Reset (int[] SuperCombo) {

        Inv_Reset(SuperCombo);

        for (int i = 0; i < SuperCombo.Length; i++)
        {
            int _random = UnityEngine.Random.Range(1, 11);
            Inv_Add(_random, SuperCombo);
        }
    }

    // vide l'inventaire (remet toute les valeur a 0).
    public void Inv_Reset(int[] target) {

        for (int i = 0; i < target.Length; i++)
        {
            target[i] = 0;
        }

    }

    // ajoute la valeur 'set' a la premier case vide rencontrer (vide = 0).


    /********************************************************************************************************************************************************************/
    public void inv_call(string ingerdiant) {

        for (int i = 0; i < ingredientTags.Length ; i++) {
            
            if (ingredientTags[i] == ingerdiant) {
                Inv_Add(i+1, Ingredient_Inventory);
            }

        }

    }

    public bool Inv_Add(int set, int[] target) {

        for (int i = 0; i < target.Length; i++) {

            if (target[i] == 0) {

                target[i] = set;
                return true;
            }
        }

        return false;
    }

    // retounre vraie si l'inventaire est plein.
    public bool Inv_Full(int[] target) {

        for (int i = 0; i < target.Length; i++) {

            if (target[i] == 0) {

                return false;
            }
        }

        return true;
    }

    //verification de l'inventaire automatique, ne s'efectue que si celuis ci est plein, on verifit alors les combo puis on le vide.
    public void Inv_Check(int[] target, int[] SuperCombo1, int[] SuperCombo2, int[] SuperCombo3, int[] SuperCombo4, int[] SuperCombo5, int[] SuperCombo6) {

        if (Inv_Full(target)) {
            int Combo = Inv_SuperCombo_Check(target, SuperCombo_1, SuperCombo_2, SuperCombo_3, SuperCombo_4, SuperCombo_5, SuperCombo_6);

            if (Combo == 0)
            {
                Combo = Inv_Combo_Check(target);
        
            }
                switch (Combo)
                {
                    case 1:
                        Score = Score + 100;
                        break;

                    case 2:
                        Score = Score + 200;
                        break;
                    case 3:
                        Score = Score + 300;
                        break;
                    case 4:
                        Score = Score + 400;
                        break;
                    case 5:
                        Score = Score + 500;
                        break;
                    case 6:
                        Score = Score + 600;
                        break;

                    case 7:
                        Score = Score + 1000;
                        break;

                    case 8:
                        Score = Score + 2000;
                        break;
                    case 9:
                        Score = Score + 3000;
                        break;
                    case 10:
                        Score = Score + 4000;
                        break;
                    case 11:
                        Score = Score + 5000;
                        break;
                    case 12:
                        Score = Score + 6000;
                        break;
                    default:
                        Debug.Log(Score);
                        break;

                }

                Inv_Reset(target);
            

        }
    }

    //verification de l'inventaire Manuelle, on verifit les combo et on le vide.
    public void Inv_Manual_Check(int[] target, int[] SuperCombo1, int[] SuperCombo2, int[] SuperCombo3, int[] SuperCombo4, int[] SuperCombo5, int[] SuperCombo6) {
        int Combo = Inv_SuperCombo_Check(target, SuperCombo_1, SuperCombo_2, SuperCombo_3, SuperCombo_4, SuperCombo_5, SuperCombo_6);

        if (Combo == 0)
        {
            Combo = Inv_Combo_Check(target);

        }
        switch (Combo)
        {
            case 1:
                Score = Score + 100;
                break;

            case 2:
                Score = Score + 200;
                break;
            case 3:
                Score = Score + 300;
                break;
            case 4:
                Score = Score + 400;
                break;
            case 5:
                Score = Score + 500;
                break;
            case 6:
                Score = Score + 600;
                break;

            case 7:
                Score = Score + 1000;
                break;

            case 8:
                Score = Score + 2000;
                break;
            case 9:
                Score = Score + 3000;
                break;
            case 10:
                Score = Score + 4000;
                break;
            case 11:
                Score = Score + 5000;
                break;
            case 12:
                Score = Score + 6000;
                break;
            default:
                Debug.Log(Score);
                break;

        }

        Inv_Reset(target);


    
    }

    public int Inv_SuperCombo_Check(int[] target, int[] SuperCombo1, int[] SuperCombo2, int[] SuperCombo3, int[] SuperCombo4, int[] SuperCombo5, int[] SuperCombo6) {

        int SuperCombo = 7;
        for (int i = 0; i < target.Length; i++) {
            if (target[i] != SuperCombo1[i])
                SuperCombo = 0;
        }
        if (SuperCombo == 1) {
            return SuperCombo;
        }

        SuperCombo = 8;
        for (int i = 0; i < target.Length; i++) {
            if (target[i] != SuperCombo2[i])
                SuperCombo = 0;
        }
        if (SuperCombo == 2) {
            return SuperCombo;
        }


        SuperCombo = 9;
        for (int i = 0; i < target.Length; i++) {
            if (target[i] != SuperCombo3[i])
                SuperCombo = 0;
        }
        if (SuperCombo == 3) {
            return SuperCombo;
        }


        SuperCombo = 10;
        for (int i = 0; i < target.Length; i++) {
            if (target[i] != SuperCombo4[i])
                SuperCombo = 0;
        }
        if (SuperCombo == 4) {
            return SuperCombo;
        }


        SuperCombo = 11;
        for (int i = 0; i < target.Length; i++) {
            if (target[i] != SuperCombo5[i])
                SuperCombo = 0;
        }
        if (SuperCombo == 5) {
            return SuperCombo;
        }


        SuperCombo = 12;
        for (int i = 0; i < target.Length; i++) {
            if (target[i] != SuperCombo6[i])
                SuperCombo = 0;
        }
        if (SuperCombo == 6) {
            return SuperCombo;
        }

        return SuperCombo;

    }


    //regarde l'inventaire et retourne le plus haut combo possible (si 0 alors il n'y a pas de combo)
    public int Inv_Combo_Check(int[] target) {

        int combo, Temp_1;

        //on test la couleur (6)
        /*  on va recuperer la valeur de l'index 0 du tableau et on va comparer cette dernierre a 
         *  tous les autre index du tableau et si elle n'est pas egale alors le combo 7 est invalide.
         *  sinon on revoie 'combo' et on met fin au test
         */

        combo = 6;
        Temp_1 = target[0];

        if (Temp_1 != 0) {

            for (int i = 1; i < target.Length; i++) {

                if (target[i] != Temp_1) {

                    combo = 0;
                }
            }

            if (combo == 6) {

                return combo;
            }

        }

        //on test la suite (5)
        /*  on va recuperer chaque valeur du tableau une par une et on va les comparer au autres
         *  index du tableau et si l'une d'entre elle est egale a l'un des autres alors le combo 5 
         *  est invalide. sinon on revoie 'combo' et on met fin au test
         */

        combo = 5;

        for (int i = 0; i < target.Length; i++) {

            Temp_1 = target[i];
            target[i] = 0;

            if (Temp_1 != 0) {

                for (int i2 = 0; i2 < target.Length; i2++) {

                    if (target[i2] == Temp_1) {

                        combo = 0;
                    }

                }

            } else {

                combo = 0;
            }

            target[i] = Temp_1;
        }

        if (combo == 5){

            return combo;
        }

       
        // on test les autre combo

        bool is_square = false;
        bool is_triple = false;
        bool is_odd = false;

        for (int i = 0; i < target.Length; i++) {

            int identicalIngredient = 0;

            if (target[i] != 0) {

                Temp_1 = target[i];
                target[i] = 0;

                for (int i2 = 0; i2 < target.Length; i2++) {

                    if (target[i2] == Temp_1) {

                        identicalIngredient++;
                    }

                }

                if (identicalIngredient == 3) {

                    is_square = true;

                } else if (identicalIngredient == 2) {

                    is_triple = true;

                } else if (identicalIngredient == 1) {

                    is_odd = true;

                }

                target[i] = Temp_1;
            }
        }

        //on test le full (4)
        if (is_odd && is_triple) {

            combo = 4;
            return combo;
            
        //on test le car�e (3)
        } else if (is_square) {

            combo = 3;
            return combo;

         //on test le triple (2)
        } else if (is_triple) {

            combo = 2;
            return combo;

        // on test la paire(1)
        } else if (is_odd) {

            combo = 1;
            return combo;
           
        // Aucun combo    
        } else {

            combo = 0;
            return combo;
        }

       
    }

    

}



