public class Prop : IDamageable
{
    public int CurrentHealth => isBroken ? 0 : 1;

    private bool isBroken;

    public void ApplyDamage(int damage)
    {
        Break();
    }

    private void Break()
    {
        isBroken = true;
    }
}

//example class using the IDamageable type directly
public class Projectile
{
    public int damage;

    public void OnHit(IDamageable damageable)
    {
        damageable.ApplyDamage(damage);
    }
}