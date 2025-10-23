using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPortero : MonoBehaviour
{

    public float recorridoPortero = 10f;
    public float velocidad = 1.5f;
    private Vector3 posInicial;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.PingPong(Time.time * velocidad, recorridoPortero) - recorridoPortero * 0.5f;
        transform.position = posInicial + new Vector3(x, 0f, 0f);
    }
}
