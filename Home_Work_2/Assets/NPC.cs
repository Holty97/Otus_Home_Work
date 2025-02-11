using UnityEngine;

public class NPC : MonoBehaviour
{
    public float health;

    public void Damage(float damage)
    {
        Debug.Log("Damage"+ damage);
        health -= damage;
        Debug.Log("Health after damage:" + health);
        
    }
    
    public void Damage(int damage)
    {
        health -= damage;
        Debug.Log("Health after damage:" + health);
    }

    public void BaseDamageMultiplier(float baseDamage, float multiplier)
    {
        Damage(baseDamage * multiplier);
    }
}