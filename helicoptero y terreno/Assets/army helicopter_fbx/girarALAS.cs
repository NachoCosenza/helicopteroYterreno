using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girarALAS : MonoBehaviour {

    private Rigidbody rb;
    public float velocidad;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.forward * velocidad);
    }

    ///////////////////////////////////////



}
