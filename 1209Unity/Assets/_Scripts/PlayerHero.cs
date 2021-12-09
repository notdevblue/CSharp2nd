using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHero : PlayerBase
{
    public GameObject firePrefab;
    public float fireForce = 5.0f;

    public override void InitPlayer(string uid)
    {
        base.InitPlayer(uid);
        Type = "Hero";
        print("Hero InitPlayer()");
    }

    public override void Move()
    {
        if (Input.GetKey(KeyCode.W)) { transform.position += transform.forward * 3.0f * Time.deltaTime; }
        if (Input.GetKey(KeyCode.S)) { transform.position -= transform.forward * 3.0f * Time.deltaTime; }
        if (Input.GetKey(KeyCode.A)) { transform.Rotate(0, -90 * Time.deltaTime, 0); }
        if (Input.GetKey(KeyCode.D)) { transform.Rotate(0, 90 * Time.deltaTime, 0); }
    }

    public override void UpdatePlayer()
    {
        base.UpdatePlayer();
    }

    public override void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = transform.position;
            pos.y = 0.8f;
            // pos.z += 1.2f;

            Instantiate(firePrefab, pos, transform.rotation).GetComponent<Rigidbody>().AddForce(transform.forward * fireForce, ForceMode.Impulse);
        }
    }
}
