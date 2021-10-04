using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAbajo : MonoBehaviour
{
    [Range(0f, 10f)]
    private float velocidad = 5;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.up * velocidad;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "DestAbajo")
        {
            Destroy(gameObject);
        }

        if (collider.gameObject.tag == "ContinueAb")
        {
            rigidbody.velocity = Vector2.up * velocidad;
        }

        if (collider.gameObject.tag == "StopAb")
        {
            rigidbody.velocity = Vector2.up * 0;
        }

        if (collider.gameObject.tag == "DestructorAb")
        {
            Destroy(gameObject);
        }
    }
}
