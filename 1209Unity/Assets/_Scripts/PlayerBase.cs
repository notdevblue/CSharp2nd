using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    public GameObject GO;
    public string UID;
    public string NickName { get; set; }
    public string Type{ get; set; } // Player, Enemy, Hero

    public float MoveSpeed = 2.0f;
    public float SpeedSpeed = 180.0f;

    GameObject target;


    public virtual void InitPlayer(string uid)
    {
        UID = uid;
        GO = gameObject;
        Type = "Base";
        print("Base Initplayer();");
    }

    public virtual void UpdatePlayer()
    {
        Move();
        Fire();
    }

    public virtual void Move()
    {

    }

    public virtual void Fire()
    {
        
    }
}
