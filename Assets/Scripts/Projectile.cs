using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;
    public float projectileSpeed = 7.5f;

    public bool isAutomatic = false;
    public PressurePlate pressurePlate;

    void Update()
    {
        if (pressurePlate.isPressed || isAutomatic)
        {
            var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint.up * projectileSpeed;
        }
    }
}
