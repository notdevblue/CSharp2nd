using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    List<PlayerBase> PlayerList = new List<PlayerBase>();

    public PlayerHero Hero { get; set; } = null;

    private static PlayerManager s_Instance = null;
    public static PlayerManager Instance {
        get {
            if(s_Instance == null) {
                s_Instance = FindObjectOfType(typeof(PlayerManager)) as PlayerManager;
            }
            return s_Instance;
        }
    }

    private void Awake()
    {
        if(s_Instance != null) return;
        s_Instance = this;
    }

    private void Update()
    {
        foreach(var item in PlayerList)
        {
            item.UpdatePlayer();
        }
    }

    public PlayerBase FindPlayer(string uid)
    {
        foreach (var item in PlayerList)
        {
            if (item.UID == uid) return item;
        }
        return null;
    }

    public void RemovePlayer(PlayerBase player)
    {
        PlayerBase p = FindPlayer(player.UID);
        PlayerList.Remove(p);
        Destroy(p.GO);
    }

    public PlayerBase AddPlayer(string prefab, string uid, string type)
    {
        GameObject go = Instantiate(Resources.Load<GameObject>(prefab));
        PlayerBase player = null;

        switch(type)
        {
            case "Hero":
                player = go.GetComponent<PlayerHero>();
                player.InitPlayer(uid);
                Hero = player as PlayerHero;
                break;

            case "Enemy":
                player = go.GetComponent<PlayerEnemy>();
                player.InitPlayer(uid);
                break;

            default:
                player = go.GetComponent<PlayerBase>();
                player.InitPlayer(uid);
                break;
        }
        PlayerList.Add(player);
        return player;
    }
}
