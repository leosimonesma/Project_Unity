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
} // sommeil fort là sinon qqn se souvient comment on écrit en français genre le viseur sur la souris j'ai plus la trad j'ai mon cerveau hs à l'aide
// update: hqsdfçà)'qài)zefahef=hefà)zhenfà=zhenfà^zf AAAAHHHH JENPEUXPLUS DE CA 0°9IQZHJGF90E°+G0°J°3+Z
// 2nde update: si c'étiat moi solo je me serais surement endormi sur ma chaise là
// 3eme update: si je parle plus réveillez moi merci
