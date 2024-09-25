using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;

    public float shootSpeed;
    public float shootCooldown;
    bool readyToShoot = true;

    public KeyCode fireButton = KeyCode.Mouse0;

    void Update()
    {
        if (Input.GetKey(fireButton) && readyToShoot)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        readyToShoot = false;

        GameObject bullet_obj = Instantiate(bullet, firePoint.position, firePoint.rotation);
        bullet_obj.GetComponent<Rigidbody>().velocity = firePoint.forward * shootSpeed;

        yield return new WaitForSeconds(shootCooldown);
        readyToShoot = true;
    }
}
