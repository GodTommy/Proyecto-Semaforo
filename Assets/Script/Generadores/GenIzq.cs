using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenIzq : MonoBehaviour
{
    public GameObject CarIzq;

    [Range(1f, 10f)]
    public float TimeGeneration = 2;
    [Range(1f, 10f)]
    public float TimeReaction = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        InicioGenIzq();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CrearCarIzq ()
    {
            Instantiate(CarIzq, transform.position, Quaternion.identity);
    }

    void InicioGenIzq()
    {
            InvokeRepeating("CrearCarIzq", TimeReaction, TimeGeneration);
    }
}
