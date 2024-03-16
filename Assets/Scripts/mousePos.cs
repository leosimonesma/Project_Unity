using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class mousePos : MonoBehaviour
{

    Vector3 pos;
    public float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        pos = UnityEngine.Input.mousePosition;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
