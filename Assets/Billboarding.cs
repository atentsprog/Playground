using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboarding : MonoBehaviour
{
    Vector3 offset;
    Transform parent;
    private void Start()
    {
        offset = transform.parent.position - transform.position;
        parent = transform.parent;
        transform.parent = null;
    }
    private void LateUpdate()
    {
        if(parent == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = parent.position - offset;
    }
}
