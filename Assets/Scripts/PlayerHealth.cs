using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float hitPoints = 60f;

    public float GetHealth() => hitPoints;

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 0)
        {
            GetComponent<DeathHandler>()?.HandleDeath();
        }
    }
}
