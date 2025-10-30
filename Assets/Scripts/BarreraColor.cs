using UnityEngine;

public class BarreraColor : MonoBehaviour
{
    private Renderer[] renderers;
    private int golpes = 0;

    void Start()
    {
        // Buscar todos los Renderers de los hijos (los cubos)
        renderers = GetComponentsInChildren<Renderer>();

        // Ponerlos verdes al inicio
        foreach (Renderer r in renderers)
        {
            r.material.color = Color.green;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Si el objeto que choca es una bala
        if (collision.gameObject.CompareTag("Bala") || collision.gameObject.CompareTag("BalaEnemiga"))
        {
            golpes++;

            // Cambiar color según el número de golpes
            Color nuevoColor = Color.green;
            switch (golpes)
            {
                case 1:
                    nuevoColor = Color.yellow;
                    break;
                case 2:
                    nuevoColor = new Color(1f, 0.5f, 0f); // naranja
                    break;
                case 3:
                    nuevoColor = Color.red;
                    break;
                case 4:
                    Destroy(gameObject); // destruye toda la barrera (padre e hijos)
                    break;
            }

            // Aplicar el color a todos los cubos hijos
            foreach (Renderer r in renderers)
            {
                r.material.color = nuevoColor;
            }

            // Destruir la bala al impactar
            Destroy(collision.gameObject);
        }
    }
}
