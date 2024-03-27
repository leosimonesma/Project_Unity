using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnerManager : MonoBehaviour
{
    [SerializeField] GameObject Ingredient_01;
    [SerializeField] GameObject Ingredient_02;
    [SerializeField] GameObject Ingredient_03;
    [SerializeField] GameObject Ingredient_04;
    [SerializeField] GameObject Ingredient_05;
    [SerializeField] GameObject Ingredient_06;
    [SerializeField] GameObject Ingredient_07;
    [SerializeField] GameObject Ingredient_08;
    [SerializeField] GameObject Ingredient_09;
    [SerializeField] GameObject Ingredient_10;

    [SerializeField] float spawner_Interval = 5f;




    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(spawnItems(spawner_Interval, SelecNextIngredient()));
    }

    private IEnumerator spawnItems(float interval, GameObject ingredient )
    {
        yield return new WaitForSeconds( interval );
        GameObject newIngredient = Instantiate( ingredient, new Vector3(Random.Range(-1f,1f), Random.Range(-2f,2f), 0f), Quaternion.identity);
        StartCoroutine(spawnItems(interval, SelecNextIngredient()));

    }
    private GameObject SelecNextIngredient()
    {
        int _random = UnityEngine.Random.Range(1, 11);
        switch (_random)
        {
            case 1:
                return Ingredient_01;
            case 2:
                return Ingredient_02;
            case 3:
                return Ingredient_03;
            case 4:
                return Ingredient_04;
            case 5:
                return Ingredient_05;
            case 6:
                return Ingredient_06;
            case 7:
                return Ingredient_07;
            case 8:
                return Ingredient_08;
            case 9:
                return Ingredient_09;
            case 10:
                return Ingredient_10;
               
            default: return null;

        }
    }
}
