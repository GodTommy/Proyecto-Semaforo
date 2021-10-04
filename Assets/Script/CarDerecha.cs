using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDerecha : MonoBehaviour
{
    [Range(0f, 10f)]
    private float velocidad = 5;

    private Rigidbody2D rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.left * velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.gameObject.tag == "DestDerecha")
        {
            Destroy(gameObject);
        }

        if (collider.gameObject.tag == "ContinueDer")
        {
            rigidbody.velocity = Vector2.left * velocidad;
        }

        if (collider.gameObject.tag == "StopDer")
        {
            rigidbody.velocity = Vector2.left * 0;
        }

        if (collider.gameObject.tag == "DestructorDer")
        {
            Destroy(gameObject);
        }
    }
}
