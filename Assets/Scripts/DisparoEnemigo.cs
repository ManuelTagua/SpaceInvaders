using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public GameObject balaEnemigaPrefab;
    public Transform puntoDisparo;
    public float fuerzaDisparo = 20f;
    public float tiempoMin = 2f, tiempoMax = 6f;
    float t;

    void Start() { t = Random.Range(tiempoMin, tiempoMax); }

    void Update()
    {
        t -= Time.deltaTime;
        if (t <= 0f)
        {
            Disparar();
            t = Random.Range(tiempoMin, tiempoMax);
        }
    }

    void Disparar()
    {
        if (!balaEnemigaPrefab || !puntoDisparo) return;

        var bala = Instantiate(balaEnemigaPrefab, puntoDisparo.position, puntoDisparo.rotation);
        if (bala.TryGetComponent(out Rigidbody rb))
        {
            // Hacia abajo relativo al dron (no global)
            rb.velocity = -transform.up * fuerzaDisparo;
        }
    }
}
