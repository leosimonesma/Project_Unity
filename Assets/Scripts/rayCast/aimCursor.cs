using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseCurs : MonoBehaviour
{
    Vector3 pos;
    [SerializeField] float speed = 1f;

    private void Update()
    {
        pos = Input.mousePosition;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
} // sommeil fort l� sinon qqn se souvient comment on �crit en fran�ais genre le viseur sur la souris j'ai plus la trad j'ai mon cerveau hs � l'aide
// update: hqsdf��)'q�i)zefahef=hef�)zhenf�=zhenf�^zf AAAAHHHH JENPEUXPLUS DE CA 0�9IQZHJGF90E�+G0�J�3+Z
// 2nde update: si c'�tiat moi solo je me serais surement endormi sur ma chaise l�
// 3eme update: si je parle plus r�veillez moi merci
