using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girar : MonoBehaviour {

    private Rigidbody rb;
    public float angle;
    public GameObject prefa;
    public Transform salida;
    public float fuerza;

    // Use this for initialization
    void Start ()
    {

        rb = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        

        if (Input.GetKey(KeyCode.E))
        {
			rb.AddRelativeTorque(Vector3.up * angle);
        }

        if (Input.GetKey(KeyCode.Q))
        {
			rb.AddRelativeTorque(Vector3.up * -angle);
        }

        ////////////////////

        if (Input.GetKey(KeyCode.RightArrow))
        {
			rb.AddRelativeTorque(Vector3.forward * angle);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
			rb.AddRelativeTorque(Vector3.forward * -angle);
        }

        
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddRelativeForce(Vector3.up * fuerza);
            }
        

        

        if (Input.GetKey(KeyCode.UpArrow))
        {
			rb.AddRelativeTorque(Vector3.left * angle);
		}

        if (Input.GetKey(KeyCode.DownArrow))
        {
			rb.AddRelativeTorque(Vector3.left * -angle);
        }


    }
}
