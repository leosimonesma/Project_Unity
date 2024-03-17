using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjectOnMouse : MonoBehaviour
{

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
