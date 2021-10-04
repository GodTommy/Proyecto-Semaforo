using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenAb : MonoBehaviour
{
    public GameObject CarAb;

    [Range(1f, 10f)]
    public float TimeGeneration = 2;
    [Range(1f, 10f)]
    public float TimeReaction = 2;

    // Start is called before the first frame update
    void Start()
    {
        InicioGenAb();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearCarAb()
    {
            Instantiate(CarAb, transform.position, Quaternion.identity);
    }

    void InicioGenAb()
    {
            InvokeRepeating("CrearCarAb", TimeReaction, TimeGeneration);
    }
}
