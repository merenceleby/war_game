using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletType;
    public Transform firePoint;
    public float Bullet_Force = 40f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletType, firePoint.position, firePoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(firePoint.forward * Bullet_Force, ForceMode.Impulse);
        }
    }
}
