using UnityEngine;

public class BalaEnemigo : MonoBehaviour
{
    [Header("Configuración")]
    public float tiempoVida = 5f;
    public float alturaMinima = -5f;

    void Start()
    {
        Destroy(gameObject, tiempoVida);
    }

    void Update()
    {
        if (transform.position.y < alturaMinima)
            Destroy(gameObject);
    }

    void OnCollisionEnter(Collision collision)
    {
        // 🧱 --- BARRERA ---
        // No dependemos del tag: buscamos directamente el script en padres e hijos
        BarreraColor barrera = collision.gameObject.GetComponentInParent<BarreraColor>();
        if (barrera != null)
        {
            barrera.SendMessage("RegistrarGolpe", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
            return;
        }

        // 🚀 --- JUGADOR ---
        if (collision.gameObject.CompareTag("Jugador"))
        {
            // Aquí luego restaremos vida
            Destroy(gameObject);
            return;
        }

        // 👾 --- ENEMIGO ---
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
            return;
        }

        // 💥 --- OTROS OBJETOS ---
        Destroy(gameObject);
    }
}
