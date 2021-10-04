using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarIzquierda : MonoBehaviour
{
    [Range(0f, 10f)]
    private float velocidad = 5;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.right * velocidad;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "DestIzquierda")
        {
            Destroy(gameObject);
        }

        if (collider.gameObject.tag == "ContinueIzq")
        {
            rigidbody.velocity = Vector2.right * velocidad;
        }

        if (collider.gameObject.tag == "StopIzq")
        {
            rigidbody.velocity = Vector2.right * 0;
        }

        if (collider.gameObject.tag == "DestructorIzq")
        {
            Destroy(gameObject);
        }
    }
}
