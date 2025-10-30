using UnityEngine;

public class GrupoEnemigos : MonoBehaviour
{
    public float velocidad = 5f;
    public float distanciaBajada = 5f;
    private bool moviendoDerecha = true;

    void Update()
    {
        transform.position += (moviendoDerecha ? Vector3.right : Vector3.left)
                              * velocidad * Time.deltaTime;
    }

    public void CambiarDireccionYBajar()
    {
        moviendoDerecha = !moviendoDerecha;
        transform.position -= new Vector3(0f, distanciaBajada, 0f);
    }
}
