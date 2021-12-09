using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemy : PlayerBase, IDamageable
{
    private int hp = 10;

    PlayerState state;

    public override void InitPlayer(string uid)
    {
        base.InitPlayer(uid);
        Type = "Enemy";
        print("Enemy InitPlayer()");

        state = GetComponent<PlayerState>();
        state.State_Start(PlayerState.eState.idle);
        state.target = PlayerManager.Instance.Hero.gameObject;
    }

    public void OnDamage(int damage)
    {
        hp -= damage;
        PlayerManager.Instance.RemovePlayer(this);
        if(hp <= 0) Destroy(gameObject);
    }

    public override void UpdatePlayer()
    {
        Move();
        Fire();
        state.State_Update();
        
    }

    
}
