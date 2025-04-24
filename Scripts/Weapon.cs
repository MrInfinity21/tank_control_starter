using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] protected Projectile _projectile;
    [SerializeField] protected float _shotSpeed = 100f;
    [SerializeField] protected Transform _shotOrigin;


    public virtual void Shoot()
    {
        Projectile projectile = Instantiate(_projectile, _shotOrigin.position, _shotOrigin.rotation);
        projectile.Fire(_shotOrigin.forward, _shotSpeed);
    }

    private void OncollisionEnter(Collision other)
    {
        
    }
}

