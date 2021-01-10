using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject gun;

    [SerializeField]
    float damage = 1f;

    public void Fire() {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }
}
