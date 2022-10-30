using UnityEngine;
using UnityEngine.AI;

public class ControladorEnemigoRojo : MonoBehaviour
{
    public NavMeshAgent agente;
    [Header("Posiciones Patrulla")]
    public Transform puntoInicio;
    public Transform puntoFinal;

    void FixedUpdate()
    {
        if (IsInPosition(puntoFinal.position)) // && !agente.isStopped
        {
#if DEBUG
            Debug.Log("punto final");
#endif
            agente.SetDestination(puntoInicio.position);
        }
        else if (IsInPosition(puntoInicio.position)) // && !agente.isStopped
        {
#if DEBUG
            Debug.Log("punto inicial");
#endif
            agente.SetDestination(puntoFinal.position);
        }
    }

    bool IsInPosition(Vector3 point)
    {
        if (transform.position.x == point.x
            && transform.position.z == point.z)
        {
            return true;
        } 
        else
        {
            return false;
        }
    }
}
