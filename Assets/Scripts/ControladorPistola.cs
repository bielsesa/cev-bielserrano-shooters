using UnityEngine;

public class ControladorPistola : MonoBehaviour
{
    public ParticleSystem efecto;
    public string tagObjetivo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Disparo();
        }
    }

    void Disparo()
    {
#if DEBUG
        Debug.Log("disparo");
#endif

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit raycastResult, 7))
        {
#if DEBUG
            Debug.Log("raycast hit");
#endif
            if (raycastResult.collider.tag.Equals(tagObjetivo))
            {
#if DEBUG
                Debug.Log("enemy hit");
#endif
                Instantiate(efecto, raycastResult.point, transform.rotation);
            }
        }
    }
}
