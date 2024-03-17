using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addFroce : MonoBehaviour
{
    Rigidbody rbody;
    Vector2 direction;
    [SerializeField] float startSpeed;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        float radiants = 0;
        while (radiants == 0)
        {
            radiants = Random.Range(0, 2 * Mathf.PI);
        }
        direction = new Vector2(Mathf.Cos(radiants), Mathf.Sin(radiants));
        direction.Normalize();
        direction *= startSpeed;
        rbody.AddForce(direction);
    }
}
