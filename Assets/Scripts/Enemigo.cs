using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private GrupoEnemigos grupo;

    void Start()
    {
        grupo = GetComponentInParent<GrupoEnemigos>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MurosInvisibles"))
        {
            if (grupo != null)
                grupo.CambiarDireccionYBajar();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
