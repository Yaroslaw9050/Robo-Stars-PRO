using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class NickNameDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text nickNameText;
    private PhotonView pv;
    private void Awake()
    {
        pv = GetComponentInParent<PhotonView>();
        if(pv.IsMine)
        {
           Destroy(gameObject);
        }
    }
    private void Start()
    {
        nickNameText.text = pv.Owner.NickName;
    }
    private void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.Rotate(Vector3.up * 180);
    }
}
