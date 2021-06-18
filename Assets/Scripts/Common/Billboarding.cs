using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboarding : MonoBehaviour
{
    public enum BillboardingType
    {
        MovePosition,
        LookAtCamera,
    }
    public BillboardingType billboardingType = BillboardingType.MovePosition;
    Transform cameraTr;
    public Vector3 offset;
    public Transform parent;
    Transform tr;
    void Start()
    {
        tr = transform;
        cameraTr = Camera.main.transform;
        if(billboardingType == BillboardingType.MovePosition)
        {
            parent = transform.parent;
            offset = parent.position - transform.position;
            transform.parent = null;
        }    
        SetBillboard();
    }
    public Vector3 angle;
    private void SetBillboard()
    {
        if(tr == null || parent == null)
        {
            Destroy(gameObject);
            return;
        }

        switch(billboardingType)
        {
            case BillboardingType.MovePosition:
                transform.position = parent.position - offset;
                break;
            case BillboardingType.LookAtCamera:
                transform.LookAt(cameraTr);
                break;
        }
    }

    void LateUpdate()
    {
        SetBillboard();
    }
}
