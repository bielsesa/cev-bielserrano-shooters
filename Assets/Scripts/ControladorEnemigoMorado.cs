using UnityEngine;
using UnityEngine.AI;

public class ControladorEnemigoMorado : MonoBehaviour
{
    public Transform objetivo;
    public GameObject pistola;
    public NavMeshAgent agente;
    public float rango = 1f;
    public float velocidad = .5f;

    //private Rigidbody _rigidbody;

    //private void Start()
    //{
    //    _rigidbody = GetComponent("Rigidbody") as Rigidbody;
    //}

    void FixedUpdate()
    {
        float distancia = Vector3.Distance(objetivo.position, transform.position);

        if (distancia <= rango)
        {
            Debug.Log("dentro de rango");
            // dispara al jugador
            //Disparar();
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
        // Usando rigidbody, con LERP para que sea mas suave
        //Vector3 nuevaPosicion = Vector3.Lerp(transform.position, objetivo.transform.position, velocidad * Time.fixedDeltaTime);
        //_rigidbody.MovePosition(nuevaPosicion);
        //transform.LookAt(objetivo);

        // Usando pathfinding
        agente.SetDestination(objetivo.transform.position);
    }

    /// <summary>
    /// 
    /// </summary>
    void Disparar()
    {
        Debug.Log("dispara");
        Ray rayOrigin = new Ray(pistola.transform.position, Vector3.forward);
        RaycastHit raycastHitInfo;

        if (Physics.Raycast(rayOrigin, out raycastHitInfo))
        {
            Debug.Log(raycastHitInfo.transform.name);
            Debug.Log(raycastHitInfo.transform.position);
        }
        Debug.Log("despues de raycast");
    }
}
