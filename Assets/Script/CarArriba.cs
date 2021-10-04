using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarArriba : MonoBehaviour
{
    [Range(0f, 10f)]
    private float velocidad = 5;

    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = Vector2.down * velocidad;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "DestArriba")
        {
            Destroy(gameObject);
        }

        if (collider.gameObject.tag == "ContinueAr")
        {
            rigidbody.velocity = Vector2.down * velocidad;
        }

        if (collider.gameObject.tag == "StopAr")
        {
            rigidbody.velocity = Vector2.down * 0;
        }

        if (collider.gameObject.tag == "DestructorAr")
        {
            Destroy(gameObject);
        }
    }
}
