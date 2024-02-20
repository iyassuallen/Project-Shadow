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

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (pressurePlate.isPressed)
        {
            var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint.up * projectileSpeed;
        }

        if (isAutomatic && timer > 2)
        {
            timer = 0;
            var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint.up * projectileSpeed;
        }
    }

    /*void Shoot()
    {
        var projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, projectileSpawnPoint.rotation);
        projectile.GetComponent<Rigidbody2D>().velocity = projectileSpawnPoint.up * projectileSpeed;
    }*/
}
