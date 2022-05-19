using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class GameNetworkManager : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject allPlayerUI;
    private PhotonView pv;

    private void Awake()
    {
        pv = gameObject.GetPhotonView();
    }
    private void Start()
    {
        if(!pv.IsMine) 
        {
            Destroy(allPlayerUI);
            return;
        }
        PhotonNetwork.Instantiate(Path.Combine("Player"), Vector3.zero, Quaternion.identity); 
    }
    public void OutOfBattle()
    {
        PhotonNetwork.AutomaticallySyncScene = false;
        PhotonNetwork.LeaveRoom(); 
        SceneManager.LoadScene(0);
    }
    
}
