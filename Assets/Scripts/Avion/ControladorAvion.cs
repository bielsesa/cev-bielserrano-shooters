using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAvion : MonoBehaviour
{
    public float velocidad;
    public float velocidadGiroHorizontal;
    public float velocidadGiroVertical;
    public float anguloGiro;
    
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent("Rigidbody") as Rigidbody;
        //_rigidbody.velocity = Vector3.forward * velocidad;
        //_rigidbody.AddForce(Vector3.forward * velocidad, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.velocity = transform.forward * velocidad * Time.deltaTime;

        transform.Rotate(Input.GetAxis("Vertical") * -velocidadGiroVertical * Time.deltaTime,
                         Input.GetAxis("Horizontal") * velocidadGiroHorizontal * Time.deltaTime,
                         0);

        //_rigidbody.AddTorque(new Vector3(Input.GetAxis("Vertical") * -velocidadGiroVertical,
        //                                    Input.GetAxis("Horizontal") * velocidadGiroHorizontal,
        //                                    Input.GetAxis("Horizontal") * -5));

        //transform.rotation = new Quaternion(Input.GetAxis("Vertical") * -velocidadGiroVertical, 
        //                                    Input.GetAxis("Horizontal") * velocidadGiroHorizontal, 
        //                                    Input.GetAxis("Horizontal") * -5, 
        //                                    anguloGiro);

        //transform.rotation = new Quaternion(transform.rotation.x + Input.GetAxis("Vertical") * -velocidadGiroVertical,
        //                                    transform.rotation.y + Input.GetAxis("Horizontal") * velocidadGiroHorizontal,
        //                                    Input.GetAxis("Horizontal") * -5,
        //                                    anguloGiro);

        if (Input.GetAxis("Horizontal") != 0)
        {

        }
        else if (Input.GetAxis("Vertical") != 0)
        {

        }
    }
}
