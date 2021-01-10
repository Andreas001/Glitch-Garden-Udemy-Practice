using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVfx;

    public void DealDamage(float damage) {
        health -= damage;

        if(health <= 0) {
            TriggerDeathVfx();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVfx() {
        if(!deathVfx) { return; }
        GameObject deathVfxObject = Instantiate(deathVfx, transform.position, Quaternion.identity);
        Destroy(deathVfxObject, 1f);
    }
}
