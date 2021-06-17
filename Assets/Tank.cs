using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    void Update()
    {
        Vector3 move = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
            move.z = 1;
        if (Input.GetKey(KeyCode.DownArrow))
            move.z = -1;
        if (Input.GetKey(KeyCode.RightArrow))
            move.x = 1;
        if (Input.GetKey(KeyCode.LeftArrow))
            move.x = -1;

        if (move.sqrMagnitude > 0)
        {
            // πÊ«‚.
            move.Normalize();
            transform.Translate(move * speed * Time.deltaTime, Space.World);

            transform.forward = move;
        }   
    }
    public float speed = 5;
}
