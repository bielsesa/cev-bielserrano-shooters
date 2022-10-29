using UnityEngine;

public class ControladorEnemigoMorado : MonoBehaviour
{

    public Transform objetivo;
    public float rango = 1f;
    public float velocidad = .5f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent("Rigidbody") as Rigidbody;
    }

    void FixedUpdate()
    {
        float distancia = Vector3.Distance(objetivo.position, transform.position);

        if (distancia <= rango)
        {
            // dispara al jugador
            Disparar();
        }
        else
        {
            // se mueve hacia el jugador
            Mover();
        }

    }

    /// <summary>
    /// 
    /// </summary>
    void Mover()
    {

        //Vector3 nuevaPosicion = Vector3.MoveTowards(transform.position, objetivo.transform.position, velocidad);
        Vector3 nuevaPosicion = Vector3.Lerp(transform.position, objetivo.transform.position, velocidad * Time.fixedDeltaTime);
        _rigidbody.MovePosition(nuevaPosicion);
        transform.LookAt(objetivo);

    }

    /// <summary>
    /// 
    /// </summary>
    void Disparar()
    {
        
    }
}
