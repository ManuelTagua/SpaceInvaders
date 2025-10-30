using UnityEngine;

public class Erupcion : MonoBehaviour
{
    public GameObject stone;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    void Update()
    {
        // Buscar si ya existe una bala en escena
        GameObject existingBullet = GameObject.FindWithTag("Bala");

        // Si no hay bala y ha pasado el tiempo de recarga, dispara
        if (existingBullet == null && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(stone, transform.position, transform.rotation);
        }
    }
}
