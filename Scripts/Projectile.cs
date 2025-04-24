using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float _lifeTime = 3f;
    
    public void Fire(Vector3 direction, float fireSpeed)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * fireSpeed, ForceMode.Impulse);
        Destroy(gameObject, _lifeTime);
    }
}
