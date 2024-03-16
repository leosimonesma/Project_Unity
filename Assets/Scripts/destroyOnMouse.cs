using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnMouse : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (CompareTag("Ingrediant"))
        {
            Destroy(gameObject);
        }
    }
}
