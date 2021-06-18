using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLuncher : MonoBehaviourPun
{
    public GameObject missile;
    public Transform startPosition;

    public LayerMask layer;
    public Transform turret;
    void Update()
    {
        if (photonView.IsMine == false)
            return;

        if(Input.GetKeyDown(KeyCode.Return))
        {
            PhotonNetwork.Instantiate(missile.name
                , startPosition.position, transform.rotation, 0);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitData, 1000, layer))
            {
                var desPos = hitData.point;

                var dir = desPos - transform.position;
                turret.forward = dir;
                //dir 방향으로 포신을 돌리자.
                Instantiate(missile
                    , startPosition.position, turret.rotation);
            }
        }
    }
}
