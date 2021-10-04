using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenDer : MonoBehaviour
{
    public GameObject CarDer;

    [Range(1f, 10f)]
    public float TimeGeneration = 2;
    [Range(1f, 10f)]
    public float TimeReaction = 2;

    // Start is called before the first frame update
    void Start()
    {
        InicioGenDer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearCarDer()
    {
            Instantiate(CarDer, transform.position, Quaternion.identity);
    }

    void InicioGenDer()
    {
            InvokeRepeating("CrearCarDer", TimeReaction, TimeGeneration);
    }
}
