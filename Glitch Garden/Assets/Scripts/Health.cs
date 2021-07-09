using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 40f;
    [SerializeField] GameObject deathVFX;

    public void DealDamage(float damage) {
        health -= damage;
        if (health <= 0) {
            TriggerDeathFVX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathFVX() {
        if(!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
    }
}
