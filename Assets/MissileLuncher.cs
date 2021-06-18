using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLuncher : MonoBehaviourPun
{
    public GameObject missile;
    public Transform startPosition;
    void Update()
    {
        if (photonView.IsMine == false)
            return;

        if(Input.GetKeyDown(KeyCode.Return))
        {
            PhotonNetwork.Instantiate(missile.name, startPosition.position, transform.rotation);
        }
    }
}
