using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Photon.Pun;
using System.IO;
using UnityEngine.Events;


public class GameNetworkManager : MonoBehaviourPunCallbacks
{
    public UnityEvent OnGameOwer;
    public UnityEvent OnGameWin;
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
    }
    public void OutOfBattle()
    {
        PhotonNetwork.AutomaticallySyncScene = false;
        PhotonNetwork.LeaveRoom(); 
        SceneManager.LoadScene(0);
    }
    
}
