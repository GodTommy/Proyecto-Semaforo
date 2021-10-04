using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenAr : MonoBehaviour
{
    public GameObject CarAr;

    [Range(1f, 10f)]
    public float TimeGeneration = 2;
    [Range(1f, 10f)]
    public float TimeReaction = 2;

    // Start is called before the first frame update
    void Start()
    {
        InicioGenAr();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void CrearCarAr ()
    {
            Instantiate(CarAr, transform.position, Quaternion.identity);
    }

    void InicioGenAr ()
    {
            InvokeRepeating("CrearCarAr", TimeReaction, TimeGeneration);
    }
}
