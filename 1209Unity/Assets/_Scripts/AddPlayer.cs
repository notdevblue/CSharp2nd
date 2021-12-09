using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayer : MonoBehaviour
{
    public float timeBetweenEnemySpawn = 5.0f;
    public float lastSpawn = 0f;

    int idx = 1;


    void Start()
    {
        PlayerManager.Instance.AddPlayer("PlayerHero", "0", "Hero");
    }


    private void Update()
    {
        if(lastSpawn < Time.time)
        {
            PlayerManager.Instance.AddPlayer("PlayerEnemy", idx++.ToString(), "Enemy").GO.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0.0f, Random.Range(-10.0f, 10.0f));
            lastSpawn = timeBetweenEnemySpawn + Time.time;
        }
    }
    
}
