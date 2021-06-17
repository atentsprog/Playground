using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLuncher : MonoBehaviour
{
    public GameObject missile;
    public Transform startPosition;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(missile, startPosition.position, transform.rotation);
        }
    }
}
