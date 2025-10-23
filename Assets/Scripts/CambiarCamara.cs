using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    public Camera camaraPrincipal;   // Main Camera
    public Camera camaraFPS;         // CamaraFPS

    void Start()
    {
        // Activamos solo la principal al inicio
        camaraPrincipal.enabled = true;
        camaraFPS.enabled = false;
    }

    void Update()
    {
        // Pulsar F para cambiar
        if (Input.GetKeyDown(KeyCode.F))
        {
            camaraPrincipal.enabled = !camaraPrincipal.enabled;
            camaraFPS.enabled = !camaraFPS.enabled;
        }
    }
}
