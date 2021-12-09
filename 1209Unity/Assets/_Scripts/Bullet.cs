using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 2;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("collision:" + other.gameObject.name);
        other.gameObject.GetComponent<IDamageable>()?.OnDamage(damage);
        Destroy(this.gameObject);
    }
}